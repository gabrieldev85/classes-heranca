namespace ClassesHerança;

public class Aluno : Pessoa{
    public int Matricula {get; set; }
    public Curso CursoAluno {get; set; }

    public Aluno(string nome, string cpf, string rg, Endereco lograduro, int matricula, Curso curso)
        : base(nome, cpf, rg, lograduro)
    {
        Matricula = matricula;
        CursoAluno = curso;
    }
}