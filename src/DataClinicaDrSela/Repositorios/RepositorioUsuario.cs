using BusinessClinicaDrSela.InterfacesRepositorios;
using BusinessClinicaDrSela.Modelos;
using DataClinicaDrSela.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClinicaDrSela.Repositorios
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
        public RepositorioUsuario(MeuContexto meuContexto) : base(meuContexto)
        {
        }
    }
}
