namespace Aula14
{
    public abstract class Administracao
    {
        

        public abstract string Id { get; set; }
        public abstract void Cadastrar();
        public abstract void Remover();
        public virtual void AtualizarCadastro()
        {

        }
        public virtual void ListarTodosOsInscritos()
        {

        }

        public void Menu()
        {
            Console.WriteLine("Qual funcão você deseja realizar?\n"
                + $"1 - Cadastrar {Id}\n"
                +$"2 - Remover {Id}\n"
                +$"3 - Listar todos os {Id}\n"
                +"4 - sair");
        }

        public virtual void MensagemCadrasto()
        {
            Console.WriteLine($"Digite as informaçoes do {Id}, nome, sobrenome e " +
                $"telefone respectivamente ");
        }
        public void SwitchCase(int funcao)
        {
            switch (funcao)
            {
                case 1: Cadastrar();
                    break;
                case 2: Remover();
                    break;
                case 3: ListarTodosOsInscritos();
                    break;
                default:Console.WriteLine("Digite um valor válido");
                    break;
            }
        }
        /// <summary>
        /// Método para inicializar 
        /// </summary>
        public void Inicializar()
        {
            Menu();
            int funcao = int.Parse(Console.ReadLine());
            while(funcao != 4) {
                SwitchCase(funcao);
                Menu();
                funcao = int.Parse(Console.ReadLine()); 
            }
        }

    }
}