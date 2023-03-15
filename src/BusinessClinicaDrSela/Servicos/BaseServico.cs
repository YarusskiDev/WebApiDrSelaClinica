using BusinessClinicaDrSela.Modelos;
using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel;

namespace BusinessClinicaDrSela.Servicos
{
    public abstract class BaseServico
    {
        protected void NotificarMsgDeErro(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                NotificarMsgDeErro(erro.ErrorMessage);
            }
        }

        protected void NotificarMsgDeErro(string msgDeErro)
        {

        }

        protected bool ExecutarValidacao<TV, TE>(TV validadorDaEntidade, TE entidadeParaSerValidade) where TV : AbstractValidator<TE> where TE : Entidade
        {
            var validador = validadorDaEntidade.Validate(entidadeParaSerValidade);

            if(validador.IsValid) return true;

            NotificarMsgDeErro(validador); 
            return false;
        }


    }

}
