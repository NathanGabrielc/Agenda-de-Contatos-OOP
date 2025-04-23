using AgendaContatos.Entities;
using AgendaContatos.Interfaces;

namespace AgendaContatos.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public IRepository<Contato> Contatos { get; }

    public UnitOfWork()
    {
        Contatos = new ContatoRepository();
    }

    public void Commit()
    {
        Console.WriteLine("Alterações salvas com sucesso.");
    }
}
