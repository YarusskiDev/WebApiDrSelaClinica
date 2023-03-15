using BusinessClinicaDrSela.Modelos;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.InterfacesServicos
{
    public interface IServicoUsuario
    {
        Task Adicionar(Usuario usuario);

        Task Atualizar(Usuario usuario);

        Task Remover(int id);
    }
}
