using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exaula2308
{
    class Contatos
    {
        private List<Contato> listaContatos;

        public List<Contato> ListaContatos
        {
            get { return listaContatos; }
        }

        public Contatos()
        {
            this.listaContatos = new List<Contato>();
        }

        public void Incluir(Contato c)
        {
            this.listaContatos.Add(c);
        }

        public void Alterar(Contato c)
        {
            foreach(Contato con in listaContatos)
            {
                if (con.Equals(c))
                {
                    con.Nome = c.Nome;
                    con.Fone = c.Fone;
                    break;
                }
            }
                
        }
        public bool Excluir(Contato c)
        {
            return this.listaContatos.Remove(c);
        }

        public Contato Pesquisar (Contato c)
        {
            foreach(Contato con in listaContatos)
            {
                if (con.Equals(c))
                {
                    return con;
                }
            }
            return null;
        }
    }
}
