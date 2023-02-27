using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.Modelos
{
    public class Profissional : Entidade
    {
        //[ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
        public string Descricao { get; set; }

        public virtual List<Atendimento> Atendimentos { get; set; }
    }
}
