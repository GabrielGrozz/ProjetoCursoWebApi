using MongoDB.Bson.Serialization.Attributes;
using ProjetoCursoWebApi.Entities.Enums;

namespace ProjetoCursoWebApi.ViewModels
{
    public class NewsViewModel
    {
        public string Hat { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public string Author { get; private set; }
        public string Img { get; private set; }
        public string Link { get; private set; }
        public StatusEnum Status { get; private set; }
    }
}
