using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.Modelos
{
    public class Atendimento:Entidade
    {
        public int IdPaciente { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
        public DateTime DataAgendamento { get; set; }
        public int IdTipoStatus { get; set; }
        public int IdTipoAtendimento { get; set; }
        public Paciente Paciente { get; set; }
        public TipoAtendimento TipoAtendimento { get; set; }
        public TipoStatusAtendimento TipoStatusAtendimento { get; set; }
        public virtual List<Profissional> Profissionais { get; set; }
    }
}
