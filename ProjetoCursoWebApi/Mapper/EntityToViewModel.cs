using API.Entities;
using AutoMapper;
using ProjetoCursoWebApi.ViewModels;

namespace ProjetoCursoWebApi.Mapper
{
    public class EntityToViewModel : Profile
    {
        public EntityToViewModel()
        {
                CreateMap<News, NewsViewModel>();
        }
    }
}
