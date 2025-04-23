using AgendaContatos.Entities;
using AgendaContatos.Interfaces;

namespace AgendaContatos.Repositories;

public class ContatoRepository : IRepository<Contato>
{
    private readonly List<Contato> _contatos = [];

    public void Add(Contato entity)
    {
        entity.Id = _contatos.Count + 1;
        _contatos.Add(entity);
    }

    public IEnumerable<Contato> GetAll() => _contatos;

    public IEnumerable<Contato> BuscarPorNome(string nome) =>
        _contatos.Where(c => c.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));
}
