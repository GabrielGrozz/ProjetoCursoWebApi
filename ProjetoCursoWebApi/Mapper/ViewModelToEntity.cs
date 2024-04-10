using API.Entities;
using AutoMapper;
using ProjetoCursoWebApi.ViewModels;

namespace ProjetoCursoWebApi.Mapper
{
    public class ViewModelToEntity : Profile
    {
        public ViewModelToEntity()
        {
            CreateMap<NewsViewModel, News>();
        }
    }
}
