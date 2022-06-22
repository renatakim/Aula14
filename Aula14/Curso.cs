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

        public override string Id { get => "Aluno"; set => throw new NotImplementedException(); }

        

        public void PreencherInformacoes(Aluno aluno)
        {
            
            aluno.Nome = Console.ReadLine();
            aluno.Sobrenome = Console.ReadLine();
            aluno.Telefone = Console.ReadLine();
        }

        public void InicializarMenuAluno(Aluno aluno)
        {
            MenuAluno();
            int funcao = int.Parse(Console.ReadLine());
            while (funcao != 5)
            {
                CaseAluno(funcao, aluno);
                MenuAluno();
                funcao = int.Parse(Console.ReadLine());
            }
        }

        public void CaseAluno(int funcao, Aluno aluno)
        {
            switch (funcao)
            {
                case 1:
                    Console.WriteLine("Digite o bimestre e a nota respectivamente");
                    for (int i = 0; i < aluno.Notas.Length; i++)
                    {
                        aluno.RegistrarNota(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    }
                    break;
                case 2:
                    aluno.ApresentarNotas();
                    break;
                case 3:
                    Console.WriteLine(aluno.MediaDasNotas());
                    break;
                case 4:
                    if (aluno.Estagio())
                    {
                        Console.WriteLine("Aluno aprovado");
                    }
                    else
                    {
                        Console.WriteLine("Aluno reprovado");
                    }
                    break;
                default:
                    Console.WriteLine("Digite um valor válido");
                    break;
            }
        }

        public void MenuAluno()
        {
            Console.WriteLine("Qual funcão você deseja realizar?\n"
                + $"1 - Cadastrar as notas\n"
                + $"2 - Apresentar as notas\n"
                + $"3 - Ver média do aluno\n"
                + "4 - Ver estágio do aluno\n" +
                "5 - Sair");
        }
        public override void Cadastrar()
        {
            Aluno aluno = new Aluno();
            MensagemCadrasto();
            PreencherInformacoes(aluno);
            aluno.Matricula = Matriculados.Count + 1;
            Matriculados.TryAdd(aluno.Matricula, aluno);
            Console.WriteLine("Aluno cadastrado" + Environment.NewLine);
            InicializarMenuAluno(aluno);
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
