using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    public class Empresa : Administracao
    {
        static public Dictionary<string, Funcionario> Contratados = new Dictionary<string, Funcionario>();

        public override string Id { get => "Funcionário"; set => throw new NotImplementedException(); }

        public void SetFuncionario(Funcionario funcionario)
        {
            funcionario.CPF = Console.ReadLine();
            funcionario.Nome = Console.ReadLine();
            funcionario.Sobrenome = Console.ReadLine();
            funcionario.Telefone = Console.ReadLine();
        }

        public override void MensagemCadrasto()
        {
            Console.WriteLine($"Digite as informaçoes do {Id},cpf, nome, sobrenome e " +
                $"telefone respectivamente ");
            
        }
        public override void Cadastrar()
        {
            Funcionario funcionario = new Funcionario();
            MensagemCadrasto();
            SetFuncionario(funcionario);
            
            Contratados.TryAdd(funcionario.CPF, funcionario);

        }

        public override void Remover()
        {
            Console.WriteLine("Qual CPF do funcionário que você deseja remover");
            string cpf = Console.ReadLine();
            if (Contratados.ContainsKey(cpf))
            {
                Contratados.Remove(cpf);
                Console.WriteLine($"Funcionário {cpf} removido");

            }
            else
            {
                Console.WriteLine("CPF não encontrado");
            }
            Console.WriteLine(Environment.NewLine);
        }
        public override void ListarTodosOsInscritos()
        {
            Console.WriteLine("Funcionários contratados: ");
            foreach (var item in Contratados)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome}");
            }
            Console.WriteLine(Environment.NewLine);
        }
        public bool Estagio()
        {
            string cpf = Console.ReadLine();

            if (Contratados.ContainsKey(cpf))
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

