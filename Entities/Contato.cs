namespace AgendaContatos.Entities;

public class Contato
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public Endereco Endereco { get; set; }
    public List<Telefone> Telefones { get; set; } = new();

    public virtual void Exibir()
    {
        Console.WriteLine("\n--- Contato ---");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Email: {Email}");

        if (Endereco != null)
        {
            Console.WriteLine("Endereço:");
            Console.WriteLine($"  Rua: {Endereco.Rua}");
            Console.WriteLine($"  Número: {Endereco.Numero}");
            Console.WriteLine($"  Bairro: {Endereco.Bairro}");
            Console.WriteLine($"  Cidade: {Endereco.Cidade}");
            Console.WriteLine($"  Estado: {Endereco.Estado}");
        }

        if (Telefones != null && Telefones.Any())
        {
            Console.WriteLine("Telefones:");
            foreach (var tel in Telefones)
            {
                Console.WriteLine($"  Tipo: {tel.Tipo} | Número: {tel.Numero}");
            }
        }
    }
}
