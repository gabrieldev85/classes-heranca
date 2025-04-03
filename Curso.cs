namespace ClassesHerança;

public class Curso {
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int CargaHoraria { get; set;}

    public Curso(string nome, string descricao, int cargaHoraria) {
        Nome = nome;
        Descricao = descricao;
        CargaHoraria = cargaHoraria;
    }
}