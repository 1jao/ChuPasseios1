using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Chu_Passeios
{
    public partial class Form3 : Form
    {
        private int id;
        public Form3()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            //apaga a listview e atualiza os dados da tabela quando o updatelistview é chamado 
            Table.Items.Clear();

            UsuarioDAO userDAO = new UsuarioDAO();
            List<Usuario> users = userDAO.SelectUser();
            //usa o funçao selectuser do UserDAO

            try
            {
                foreach (Usuario user in users)
                    
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Senha);
                    Table.Items.Add(lv);
                    //ele pega a funçao listview item e coloca como "LV" e pega os subitens da tabela da classe user 
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }




        private void btmdel_Click(object sender, EventArgs e)
        {
            //botão de deletar
            //pega a função delete no UserDAO
            int id = int.Parse(textBox4.Text);
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.deleteUser(id);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void Table_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = Table.FocusedItem.Index;
            textBox4.Text = Table.Items[index].SubItems[0].Text;
            textBox1.Text = Table.Items[index].SubItems[1].Text;
            textBox2.Text = Table.Items[index].SubItems[2].Text;
            textBox3.Text = Table.Items[index].SubItems[3].Text;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            //botão de Atualizar
            //pega a função update no UserDAO
            Usuario usuario = new Usuario(int.Parse(textBox4.Text),textBox1.Text, textBox2.Text,Criptografia.CriptografarSenha( textBox3.Text));
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.updateUsuario(usuario);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            UpdateListView();
        }
    }
}