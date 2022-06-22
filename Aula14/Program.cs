using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Empresa empresa = new Empresa();
            empresa.Inicializar();
            
            Curso curso = new Curso();
            curso.Inicializar();
            
        }
    }
}
