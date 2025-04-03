namespace ClassesHerança;

public class Pessoa {
    public string Nome  = "Jader";
    public string Cpf {get; set;}

    public string Rg { get; set;}

    public Endereco Lograduro { get; set;}

    public Pessoa(string nome, string cpf, string rg, Endereco lograduro) {
        Nome = nome;
        Cpf = cpf;
        Rg = rg;
        Lograduro = lograduro;
    }

}