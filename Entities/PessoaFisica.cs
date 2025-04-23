namespace AgendaContatos.Entities;

public class PessoaFisica : Contato
{
    public string Cpf { get; set; }

    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine($"CPF: {Cpf}");
    }
}
