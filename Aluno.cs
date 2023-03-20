namespace OrientacaoObjetoAluno1
{
    public class Aluno
    {
        public string? Nome;
        public int Idade;
        public int Serie;

        public void Apresentar()
        {
            Console.WriteLine($"O aluno {Nome} tem {Idade} anos e pertence ao {Serie} ano.");
        }
    }
}