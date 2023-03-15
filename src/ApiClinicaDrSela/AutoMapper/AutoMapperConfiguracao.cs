using ApiClinicaDrSela.ViewModel;
using AutoMapper;
using BusinessClinicaDrSela.Modelos;

namespace ApiClinicaDrSela.AutoMapper
{
    public class AutoMapperConfiguracao:Profile
    {
        public AutoMapperConfiguracao()
        {
            CreateMap<Endereco,EnderecoViewModel>().ReverseMap();
            CreateMap<Atendimento,AtendimentoViewModel>().ReverseMap();
            CreateMap<Paciente,PacienteViewModel>().ReverseMap();
            CreateMap<Pessoa,PessoaViewModel>().ReverseMap();
            CreateMap<Usuario,UsuarioViewModel>().ReverseMap();
        }
    }
}
