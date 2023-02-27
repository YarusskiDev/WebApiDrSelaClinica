using BusinessClinicaDrSela.InterfacesRepositorios;
using BusinessClinicaDrSela.Modelos;
using DataClinicaDrSela.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataClinicaDrSela.Repositorios
{
    public abstract class RepositorioBase<TEntidade> : IRepositorio<TEntidade> where TEntidade : Entidade, new()
    {
        readonly MeuContexto _meuContexto;
        readonly DbSet<TEntidade> _dbSet;
        public RepositorioBase(MeuContexto meuContexto)
        {
            _meuContexto= meuContexto;
            _dbSet= _meuContexto.Set<TEntidade>();
        }
        public async Task Adicionar(TEntidade entidade)
        {
            _dbSet.Add(entidade);   // perguntar pq essa desgraça precisa de await, se o retorno do savechances é vem certo e essa porra é void, pq precisa de await
            await SaveChanges();         
        }

        public async Task<List<TEntidade>> BuscarTodos()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntidade> BuscarUm(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Dispose()
        {
            _meuContexto?.Dispose();
        }

        public async Task Remover(int Id)
        {
           _dbSet.Remove(new TEntidade { Id = Id });
           await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await _meuContexto.SaveChangesAsync();
        }

        public async Task Update(TEntidade entidade)
        {
             _dbSet.Update(entidade);
             await SaveChanges();
        }
    }
}
