using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.Modelos
{
    public class Pessoa:Entidade
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string NomeDaMae { get; set; }
        public string NomeDoPai { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Imagem { get; set; }
        public virtual Endereco Endereco { get; set; }
        public Usuario Usuario { get; set; }
        public Paciente Paciente { get; set; }
        public Profissional Profissional { get; set; }

    }
}
