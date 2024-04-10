using MongoDB.Bson.Serialization.Attributes;
using ProjetoCursoWebApi.Entities.Enums;
using System;

namespace API.Entities
{
    public class News : BaseEntity
    {
        [BsonElement("hat")]
        public string Hat { get; private set; }

        [BsonElement("title")]
        public string Title { get; private set; }

        [BsonElement("text")]
        public string Text { get; private set; }

        [BsonElement("author")]
        public string Author { get; private set; }

        [BsonElement("img")]
        public string Img { get; private set; }

        [BsonElement("link")]
        public string Link { get; private set; }

        [BsonElement("publishDate")]
        public DateTime PublishDate { get; private set; }

        [BsonElement("status")]
        public StatusEnum Status { get; private set; }

        public News(string hat, string title, string text, string author, string img, string link, StatusEnum status)
        {
            Hat = hat;
            Title = title;
            Text = text;
            Author = author;
            Img = img;
            Link = link;
            PublishDate = DateTime.Now;
            Status = status;
        }

        //método para alterar o status
        public StatusEnum SetStatus(StatusEnum status)
        {
            switch (status)
            {
                case StatusEnum.Active:
                    status = StatusEnum.Active;
                        break;
                case StatusEnum.Inactive:
                    status = StatusEnum.Inactive;
                        break;
                case StatusEnum.Draft:
                    status = StatusEnum.Draft;
                        break;
            }
            return status;
        }
    }
}
