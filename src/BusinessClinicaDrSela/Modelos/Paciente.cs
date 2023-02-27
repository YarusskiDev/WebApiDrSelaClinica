using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessClinicaDrSela.Modelos
{
    public class Paciente:Entidade
    {
        //[ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
        public List<Atendimento> Atendimentos { get; set; }
    }
}
