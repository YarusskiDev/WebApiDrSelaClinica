using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.Modelos
{
    public class Usuario:Entidade
    {
        //[ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
