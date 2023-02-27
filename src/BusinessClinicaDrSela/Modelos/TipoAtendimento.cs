using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.Modelos
{
    public class TipoAtendimento:Entidade
    {
        public string Descricao { get; set; }
        public List<Atendimento> Atendimentos { get; set; }
    }
}
