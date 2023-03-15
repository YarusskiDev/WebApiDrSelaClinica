using ApiClinicaDrSela.ViewModel;
using AutoMapper;
using BusinessClinicaDrSela.InterfacesRepositorios;
using BusinessClinicaDrSela.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiClinicaDrSela.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        readonly private IMapper _mappper;
        readonly private IRepositorioPessoa _repositorioPessoa;
        public PessoaController(IMapper mappper, IRepositorioPessoa pessoa)
        {
            _mappper = mappper;
            _repositorioPessoa = pessoa;
        }

        [HttpGet]
        public async Task<IEnumerable<PessoaViewModel>> BuscarTodos()
        {
            return _mappper.Map<IEnumerable<PessoaViewModel>>(await _repositorioPessoa.BuscarTodos());
        }

        [HttpGet("{id}")]
        public async Task<PessoaViewModel> BuscarUm(int id)
        {
            return _mappper.Map<PessoaViewModel>( await _repositorioPessoa.BuscarUm(id));
        }

        // POST api/<PessoaController>
        [HttpPost("criarpessoa")]
        public async Task<ActionResult<PessoaViewModel>> CriarPessoa([FromBody] PessoaViewModel pessoa)
        {
            if (ModelState.IsValid) return pessoa;

            var imgPrefixo = Guid.NewGuid() + "_";
            if (!await UploadArquivo(pessoa.ImgUpload, imgPrefixo))
            {
                return pessoa;

            }

            pessoa.Imagem = imgPrefixo + pessoa.ImgUpload.FileName;
            await _repositorioPessoa.Adicionar(_mappper.Map<Pessoa>(pessoa));
            return Ok(pessoa);

        }

        // PUT api/<PessoaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PessoaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        private async Task<bool> UploadArquivo(IFormFile arquivo, string imgPrefixo)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Imagens" + imgPrefixo);
            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Já existe um arquivo com esse nome!");
                return false;
            }
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await arquivo.CopyToAsync(stream);
            }

            return true;
        }
    }
}
