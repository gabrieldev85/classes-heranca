//Gabriel Coelho Severino

using System;
using System.Collections.Generic;
using ClassesHerança;

class Program
{
    static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        Endereco endereco = new Endereco("Rua Central", 456, "Centro", "Lages", "SC", "88500-000");

        pessoas.Add(new Pessoa("Gabriel Coelho Severino", "123.456.789-00", "12.345.678-9", endereco));

        pessoas.Add(new Funcionario("Carlos Souza", "987.654.321-00", "98.765.432-1", endereco, 4500, "F001"));

        Curso cursoSI = new Curso("Sistemas de Informação", "Curso voltado para tecnologia da informação", 3200);
        Curso cursoEngSoft = new Curso("Engenharia de Software", "Foco no desenvolvimento de software", 3600);
        Curso cursoAdm = new Curso("Administração", "Gestão empresarial", 2800);

        pessoas.Add(new Aluno("Maria Oliveira", "111.222.333-44", "11.222.333-4", endereco, 1001, cursoSI));
        pessoas.Add(new Aluno("José Santos", "222.333.444-55", "22.333.444-5", endereco, 1002, cursoEngSoft));
        pessoas.Add(new Aluno("Ana Pereira", "333.444.555-66", "33.444.555-6", endereco, 1003, cursoAdm));

        pessoas.Add(new Professor("Pedro Henrique", "444.555.666-77", "44.555.666-7", endereco, 7500, "P001", "Mestre", "Tecnologia"));
        pessoas.Add(new Professor("Fernanda Lima", "555.666.777-88", "55.666.777-8", endereco, 8000, "P002", "Doutora", "Matemática"));

        pessoas.Add(new Coordenador("Cláudia Mendes", "666.777.888-99", "66.777.888-9", endereco, 9000, "C001", "AbcBolinhas"));

        pessoas.Add(new TecnicoAdministrativo("Marcos Rocha", "777.888.999-00", "77.888.999-0", endereco, 5000, "T001", "Desenvolvedor"));
        pessoas.Add(new TecnicoAdministrativo("Beatriz Souza", "888.999.000-11", "88.999.000-1", endereco, 4800, "T002", "Suporte Técnico"));

        Console.WriteLine("\n===== Lista de Pessoas Cadastradas =====\n");
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"Tipo: {pessoa.GetType().Name}");
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"CPF: {pessoa.Cpf}");
            Console.WriteLine($"RG: {pessoa.Rg}");
            Console.WriteLine($"Endereço: {pessoa.Lograduro.Rua}, {pessoa.Lograduro.Numero}, {pessoa.Lograduro.Bairro} - {pessoa.Lograduro.Cidade}/{pessoa.Lograduro.Estado}");
            
            if (pessoa is Funcionario funcionario)
            {
                Console.WriteLine($"Salário: R$ {funcionario.Salario}");
                Console.WriteLine($"Matrícula: {funcionario.Matricula}");

                if (pessoa is Professor professor)
                {
                    Console.WriteLine($"Titulação: {professor.Titulacao}");
                    Console.WriteLine($"Área: {professor.Area}");
                }
                else if (pessoa is Coordenador coordenador)
                {
                    Console.WriteLine($"Senha do Alarme: {coordenador.SenhaAlarme}");
                }
                else if (pessoa is TecnicoAdministrativo tecnico)
                {
                    Console.WriteLine($"Função: {tecnico.Funcao}");
                }
            }
            else if (pessoa is Aluno aluno)
            {
                Console.WriteLine($"Matrícula: {aluno.Matricula}");
                Console.WriteLine($"Curso: {aluno.CursoAluno.Nome} ({aluno.CursoAluno.Descricao})");
                Console.WriteLine($"Carga Horária: {aluno.CursoAluno.CargaHoraria} horas");
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
