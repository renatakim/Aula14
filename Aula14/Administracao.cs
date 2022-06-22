namespace Aula14
{
    public abstract class Administracao
    {
        public abstract void Cadastrar();
        public abstract void Remover();
        public virtual void AtualizarCadastro()
        {

        }
        public virtual void ListarTodosOsInscritos()
        {

        }
    }
}