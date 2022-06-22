namespace Aula14
{
    public class Aluno
    {
        public int Matricula;
        public string Nome;
        public string Sobrenome;
        public string Telefone;
        public int[] Notas = new int[4];


        public void RegistrarNota(int bimestre, int notas)
        {
            this.Notas[bimestre] = notas;
        }

        void ApresentarNotas()
        {
            for(int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine($"{i + 1} bimestre / nota {Notas[i]}");
            }   
        }

        int MediaDasNotas()
        {
            int media=0;
            foreach(int nota in Notas)
            {
                media += nota;
            }
            return media = media / 4;
        }

        public void Estagio()
        {
            if(MediaDasNotas() < 6)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}
