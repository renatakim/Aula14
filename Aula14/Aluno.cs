namespace Aula14
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public int[] Notas = new int[4];
        


        public void RegistrarNota(int bimestre, int notas)
        {
            this.Notas[bimestre] = notas;
        }

        public void ApresentarNotas()
        {
            for(int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine($"{i + 1} bimestre / nota {Notas[i]}");
            }   
        }


        public int MediaDasNotas()
        {
            int media=0;
            foreach(int nota in Notas)
            {
                media += nota;
            }
            return media = media / 4;
        }

        public bool Estagio()
        {
            if(MediaDasNotas() < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
