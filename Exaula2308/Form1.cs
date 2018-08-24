using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exaula2308
{
    public partial class Form1 : Form
    {
        Contatos c = new Contatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Limpa";
            button1.Enabled = false;
            button2.Text = "Gravar";
            button3.Text = "Pesquisar";
            button4.Text = "Deletar";
            button5.Text = "Listar";
            label1.Text = "Email";
            label2.Text = "Nome";
            label3.Text = "Fone";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Contato con = new Contato(textBox1.Text, textBox2.Text, textBox3.Text);
            if (c.Pesquisar(con) == null)
            {
                c.Incluir(con);
                MessageBox.Show("Incluído com sucesso!");
            }
            else
            {
                c.Alterar(con);
                MessageBox.Show("Alterado com sucesso!");
            }
            button1.Enabled = (c.ListaContatos.Count > 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contato con = new Contato(textBox1.Text, textBox2.Text, textBox3.Text);
            
            if(c.Pesquisar(con)==null)
            {
                MessageBox.Show("Contato inexistente");
            }
            else
            {
                foreach(Contato cont in c.ListaContatos)
                {
                    if (cont.Equals(con))
                    {
                        listBox1.Items.Add("Email: " + cont.Email);
                        listBox1.Items.Add("Nome: " + cont.Nome);
                        listBox1.Items.Add("Fone: " + cont.Fone);
                    }
                }
            }
            button1.Enabled = (c.ListaContatos.Count > 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Contato con = new Contato(textBox1.Text, textBox2.Text, textBox3.Text);
            if (!c.Excluir(con))
                MessageBox.Show("Contato inexistente");
            else
                MessageBox.Show("Deletado com sucesso");
            button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Contato cont in c.ListaContatos)
            {
                 listBox1.Items.Add("Email: " + cont.Email);
                 listBox1.Items.Add("Nome: " + cont.Nome);
                 listBox1.Items.Add("Fone: " + cont.Fone);
            }
            button1.Enabled = (c.ListaContatos.Count > 0);
        }
    }
}
