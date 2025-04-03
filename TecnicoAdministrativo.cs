namespace ClassesHerança;

public class TecnicoAdministrativo : Funcionario {

    public string Funcao {get; set;}

    public TecnicoAdministrativo(string nome, string cpf, string rg, Endereco lograduro , decimal salario, string matricula, string funcao)
        :base(nome, cpf, rg, lograduro, salario, matricula) {

        Funcao = funcao;
    }

}