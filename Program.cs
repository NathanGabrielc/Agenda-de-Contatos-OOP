using AgendaContatos.Entities;
using AgendaContatos.Repositories;
using AgendaContatos.Factories;

var unitOfWork = new UnitOfWork();
bool sair = false;

while (!sair)
{
    Console.WriteLine("==== AGENDA DE CONTATOS ====");
    Console.WriteLine("1 - Adicionar Pessoa Física");
    Console.WriteLine("2 - Adicionar Pessoa Jurídica");
    Console.WriteLine("3 - Listar Contatos");
    Console.WriteLine("4 - Buscar por Nome");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");
    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("CPF: ");
            var cpf = Console.ReadLine();
            var endPF = CriarEndereco();
            var telsPF = CriarTelefones();

            var pf = ContatoFactory.CriarPessoaFisica(nome, email, cpf, endPF, telsPF);
            unitOfWork.Contatos.Add(pf);
            unitOfWork.Commit();
            break;

        case "2":
            Console.Write("Nome: ");
            var nomeJ = Console.ReadLine();
            Console.Write("Email: ");
            var emailJ = Console.ReadLine();
            Console.Write("CNPJ: ");
            var cnpj = Console.ReadLine();
            var endPJ = CriarEndereco();
            var telsPJ = CriarTelefones();

            var pj = ContatoFactory.CriarPessoaJuridica(nomeJ, emailJ, cnpj, endPJ, telsPJ);
            unitOfWork.Contatos.Add(pj);
            unitOfWork.Commit();
            break;

        case "3":
            foreach (var contato in unitOfWork.Contatos.GetAll())
                contato.Exibir();
            break;

        case "4":
            Console.Write("Digite o nome para busca: ");
            var busca = Console.ReadLine();
            var encontrados = unitOfWork.Contatos.BuscarPorNome(busca);
            foreach (var contato in encontrados)
                contato.Exibir();
            break;

        case "0":
            sair = true;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine();
}

static Endereco CriarEndereco()
{
    Console.Write("Rua: ");
    var rua = Console.ReadLine();
    Console.Write("Número: ");
    var numero = Console.ReadLine();
    Console.Write("Bairro: ");
    var bairro = Console.ReadLine();
    Console.Write("Cidade: ");
    var cidade = Console.ReadLine();
    Console.Write("Estado: ");
    var estado = Console.ReadLine();

    return new Endereco { Rua = rua, Numero = numero, Bairro = bairro, Cidade = cidade, Estado = estado };
}

static List<Telefone> CriarTelefones()
{
    var telefones = new List<Telefone>();
    string continuar;

    do
    {
        Console.Write("Tipo (Celular, Residencial, Comercial): ");
        var tipo = Console.ReadLine();
        Console.Write("Número: ");
        var numero = Console.ReadLine();
        telefones.Add(new Telefone { Tipo = tipo, Numero = numero });

        Console.Write("Adicionar outro telefone? (s/n): ");
        continuar = Console.ReadLine()?.ToLower();
    } while (continuar == "s");

    return telefones;
}
