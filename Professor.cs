namespace ClassesHerança;

public class Professor : Funcionario {

    public string Titulacao {get; set;}
    public string Area {get; set;}

    public Professor(string nome, string cpf, string rg, Endereco lograduro, decimal salario, string matricula, string titulacao, string area)
        : base(nome, cpf, rg, lograduro, salario, matricula) {

            Titulacao = titulacao;
            Area = area;
        }

}