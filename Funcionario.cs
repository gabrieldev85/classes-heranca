namespace ClassesHerança;

public class Funcionario : Pessoa {

    public decimal Salario { get; set; }
    public string Matricula { get; set; }

    public Funcionario(string nome, string cpf, string rg, Endereco logradura, decimal salario, string matricula)
    : base(nome, cpf, rg, logradura) {
        
        Salario = salario;
        Matricula = matricula;
    }

}