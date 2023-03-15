using BusinessClinicaDrSela.Modelos;
using Microsoft.AspNetCore.Http;
using System;

namespace ApiClinicaDrSela.ViewModel
{
    public class PessoaViewModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string NomeDaMae { get; set; }
        public string NomeDoPai { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Imagem { get; set; }
        public IFormFile ImgUpload { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}
