using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chu_Passeios
{
    public partial class Form1 : Form
    {
        private int id;
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateListView()
            //pega a função select da UserDAO
        {

            Table.Items.Clear();
            UsuarioDAO userDAO = new UsuarioDAO();
            List<Usuario> users = userDAO.SelectUser();

            try
            {
                foreach (Usuario user in users)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Senha);
                    Table.Items.Add(lv);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
            //ao dar doubleclick na tabela, ele vai colocar os dados nas textsbox
        {
            int index;
            index = Table.FocusedItem.Index;
            id = int.Parse(Table.Items[index].SubItems[0].Text);
            textBox1.Text = Table.Items[index].SubItems[1].Text;
            textBox2.Text = Table.Items[index].SubItems[2].Text;
            textBox3.Text = Table.Items[index].SubItems[3].Text;

        }
        private void btmenter_Click(object sender, EventArgs e)
            //Botão de cadastrar usuários 
        {
            if (checkBox1.Checked)
                // se o textbox não estiver selecionado, irá mostrar a mensagem "aceite os termos da empresa"
            {
                Usuario usuario = new Usuario(textBox1.Text, textBox2.Text,Criptografia.CriptografarSenha(textBox3.Text));
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.insertUsuario(usuario);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("aceite os termos da empresa");
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
            // quando iniciar o form1 ele dá um updatelistview
        {
            UpdateListView();
        }
        private void button1_Click(object sender, EventArgs e)
            //leva o usuário para o form3
        {
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
