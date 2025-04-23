namespace AgendaContatos.Entities;

public class PessoaJuridica : Contato
{
    public string Cnpj { get; set; }

    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine($"CNPJ: {Cnpj}");
    }
}
