using BusinessClinicaDrSela.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.InterfacesServicos
{
    public interface IServicoPessoa
    {
        Task Adicionar(Pessoa pessoa);

        Task Atualizar(Pessoa pessoa);

        Task Remover(int id);

        Task AtualizarEndereco(Endereco endereco);

    }
}
