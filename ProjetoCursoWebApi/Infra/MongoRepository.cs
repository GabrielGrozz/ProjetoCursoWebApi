using API.Entities;

namespace ProjetoCursoWebApi.Infra
{
    //classe que irá fazer a conexão com o banco de dados
    public class MongoRepository<T> : IMongoRepository<T> where T : BaseEntity
    {
        public T Create(T news)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<T> Get()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, T entity)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMongoRepository<T>
    {
        List<T> Get();
        T GetById(int id);
        T Create(T news);
        void Update(string id,T entity);
        void Delete(string id);
    }
}
