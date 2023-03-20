using OrientacaoObjetoAluno1;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "John";
        aluno1.Idade = 18;
        aluno1.Serie = 8;
        aluno1.Apresentar();

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Mary";
        aluno2.Idade = 20;
        aluno2.Serie = 9;
        aluno2.Apresentar();

    }
}
