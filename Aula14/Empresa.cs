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
        public override void Cadastrar()
        {
            Funcionario funcionario = new Funcionario();
            string nome = "";
            string sobrenome = "";
            string telefone = "";
            string cpf = "";
            double salario = 0;

            Contratados.TryAdd(cpf, funcionario);

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

