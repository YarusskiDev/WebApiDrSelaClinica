using BusinessClinicaDrSela.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClinicaDrSela.Validations
{
    public class ValidacaoPessoa : AbstractValidator<Pessoa>
    {
        public bool ValidaIdade(DateTime DataNascimento)
        {
            var validaIdade = DataNascimento.Year - DateTime.Now.Year;

            if (validaIdade >= 14)
            {
                return true;
            }
            return false;
        }
        public ValidacaoPessoa()
        {
            RuleFor(p => p.DataNascimento).NotNull().NotEmpty().WithMessage("O {PropertyName} deve ser preenchido")
                .Must(ValidaIdade)
                .WithMessage("A data de nascimento deve ser maior que 14 anos");

            RuleFor(p => p.Nome).NotNull().NotEmpty().WithMessage("O {PropertyName} deve ser preenchido")
                .MinimumLength(3).WithMessage("O {PropertyName} deve ter um tamanho maior que 3 letras");

            RuleFor(p => p.Cpf).NotNull().NotEmpty().WithMessage("O {PropertyName} deve ser preenchido")
                .MinimumLength(11).WithMessage("O {PropertyName} deve ter um tamanho maior que 11 letras");

            RuleFor(p => p.Telefone).NotNull().NotEmpty().WithMessage("O {PropertyName} deve ser preenchido")
                .MinimumLength(9).WithMessage("O {PropertyName} deve ter um tamanho maior que 9 letras");

            RuleFor(p => p.NomeDaMae).NotNull().NotEmpty().WithMessage("O {PropertyName} deve ser preenchido")
                .MinimumLength(3).WithMessage("O {PropertyName} deve ter um tamanho maior que 3 letras");

            RuleFor(p => p.NomeDoPai).NotNull().NotEmpty().WithMessage("O {PropertyName} deve ser preenchido")
                .MinimumLength(3).WithMessage("O {PropertyName} deve ter um tamanho maior que 3 letras");

            RuleFor(p => p.Rg).NotNull().NotEmpty().WithMessage("O {PropertyName} deve ser preenchido")
                .MinimumLength(3).WithMessage("O {PropertyName} deve ter um tamanho maior que 9 letras");


        }
    }
}
