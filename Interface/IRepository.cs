namespace AgendaContatos.Interfaces;

public interface IRepository<T>
{
    void Add(T entity);
    IEnumerable<T> GetAll();
    IEnumerable<T> BuscarPorNome(string nome);
}
