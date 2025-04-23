using AgendaContatos.Entities;

namespace AgendaContatos.Interfaces;

public interface IUnitOfWork
{
    IRepository<Contato> Contatos { get; }
    void Commit();
}
