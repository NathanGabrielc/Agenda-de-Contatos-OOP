using AgendaContatos.Entities;

namespace AgendaContatos.Factories;

public static class ContatoFactory
{
    public static PessoaFisica CriarPessoaFisica(string nome, string email, string cpf, Endereco endereco, List<Telefone> telefones)
    {
        return new PessoaFisica
        {
            Nome = nome,
            Email = email,
            Cpf = cpf,
            Endereco = endereco,
            Telefones = telefones
        };
    }

    public static PessoaJuridica CriarPessoaJuridica(string nome, string email, string cnpj, Endereco endereco, List<Telefone> telefones)
    {
        return new PessoaJuridica
        {
            Nome = nome,
            Email = email,
            Cnpj = cnpj,
            Endereco = endereco,
            Telefones = telefones
        };
    }
}
