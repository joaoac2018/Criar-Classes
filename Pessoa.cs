using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarClasse
{
    class Pessoa
    {
        public String Nome { get => Nome; set => Nome = value; }
        public String Endereco { get => Endereco; set => Endereco = value; }
        public String Telefone { get => Telefone; set => Telefone = value; }
        
        public Pessoa() { }

        public Pessoa(String Nome, String Endereco, String Telefone)
        {
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
        }

        public void setNome(String Nome)
        {
            this.Nome = Nome;
        }

        public String getNome()
        {
            return this.Nome;
        }

        public void setEndereco(String Endereco)
        {
            this.Endereco = Endereco;
        }

        public String getEndereco()
        {
            return this.Endereco;
        }

        public void setTelefone(String Telefone)
        {
            this.Telefone = Telefone;
        }

        public String getTelefone()
        {
            return this.Telefone;
        }
    }
}
