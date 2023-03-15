using BusinessClinicaDrSela.InterfacesServicos;
using BusinessClinicaDrSela.Modelos;
using BusinessClinicaDrSela.Validations;
using FluentValidation;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.Servicos
{
    public class ServicoPessoa : BaseServico, IServicoPessoa
    {
        public async Task Adicionar(Pessoa pessoa)
        {
            if (!ExecutarValidacao(new ValidacaoPessoa(), pessoa)) ;
        }

        public async Task Atualizar(Pessoa pessoa)
        {
            if !ExecutarValidacao(new ValidacaoPessoa(), pessoa)) ;
        }

        public Task Remover(int id)
        {
            throw new System.NotImplementedException();
        }
        public Task AtualizarEndereco(Endereco endereco)
        {
            throw new System.NotImplementedException();
        }
    }

}
