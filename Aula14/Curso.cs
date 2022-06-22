using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    public class Curso : Administracao
    {
        static public int numAlunos = 0;
        static public Dictionary<int, Aluno> Matriculados = new Dictionary<int, Aluno>();
        public override void Cadastrar()
        {
            Aluno aluno = new Aluno();
            string nome ="";
            string sobrenome = "";
            string telefone = "";
            aluno.AtualizarCadastro(nome,sobrenome,telefone);
            aluno.Matricula = Matriculados.Count + 1;
            Matriculados.TryAdd(aluno.Matricula, aluno);
            Console.WriteLine("Aluno cadastrado" + Environment.NewLine);
        }

        public override void Remover()
        {
            Console.WriteLine("Qual a matrícula que você deseja remover");
            int matricula = int.Parse(Console.ReadLine());
            if (Matriculados.ContainsKey(matricula))
            {
                Matriculados.Remove(matricula);
                Console.WriteLine($"Aluno de matrícula {matricula}removido");

            }
            else
            {
                Console.WriteLine("Aluno não encontrado");
            }
            Console.WriteLine(Environment.NewLine);
        }

        public override void AtualizarCadastro()
        {
            base.AtualizarCadastro();
        }

        public override void ListarTodosOsInscritos()
        {
            Console.WriteLine("Alunos matriculádos: ");
            foreach (var item in Matriculados)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome}");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }

}
