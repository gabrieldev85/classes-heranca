namespace ClassesHerança;

public class Coordenador : Funcionario{

    public string SenhaAlarme { get; set; }

    public Coordenador(string nome, string cpf, string rg, Endereco lograduro, decimal salario, string matricula, string senhaAlarme)
        :base(nome, cpf, rg, lograduro, salario, matricula) {

            SenhaAlarme = senhaAlarme;

        }

}