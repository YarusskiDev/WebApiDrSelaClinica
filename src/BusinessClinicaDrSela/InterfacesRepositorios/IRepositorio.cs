using BusinessClinicaDrSela.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.InterfacesRepositorios
{
    public interface IRepositorio<TEntidade> : IDisposable where TEntidade : Entidade
    {
        Task<TEntidade> BuscarUm(int id);
        Task<List<TEntidade>> BuscarTodos();
        Task Adicionar(TEntidade entidade);
        Task Remover(int Id);
        Task Update(TEntidade entidade);
        Task<int> SaveChanges();

    }
}
