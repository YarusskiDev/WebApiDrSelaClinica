using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.Modelos
{
    public class Endereco : Entidade
    {
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }

        //[ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }

    }
}
