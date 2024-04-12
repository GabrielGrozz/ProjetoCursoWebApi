namespace ProjetoCursoWebApi.Infra
{
    //classe herdando a interface
    public class DataBaseSettings : IDataBaseSettings
    { 
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    //interface da classe
    public interface IDataBaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
