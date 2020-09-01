using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.setNome("Renato Violin");
            p1.setEndereco("Rua: Alessandro silva, 20");
            p1.setTelefone("1140132432");
        }
    }
}
