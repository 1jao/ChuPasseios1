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




        private void btmdel_Click(object sender, EventArgs e)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Cadastro_Cliente WHERE ID = @id";

            sqlCommand.Parameters.AddWithValue("@id", textBox4.Text);

            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Exclusão foi feita com sucesso",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                UpdateListView();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        private void Table_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = Table.FocusedItem.Index;

            textBox1.Text = Table.Items[index].SubItems[1].Text;
            textBox2.Text = Table.Items[index].SubItems[2].Text;
            textBox3.Text = Table.Items[index].SubItems[3].Text;
            textBox4.Text = Table.Items[index].SubItems[0].Text;
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
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Cadastro_Cliente SET Nome = @nome, Email = @email, Serie = @serie WHERE ID = @id";

            sqlCommand.Parameters.AddWithValue("@id", textBox4.Text);
            sqlCommand.Parameters.AddWithValue("@nome", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@email", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@serie", textBox3.Text);

            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("A edição foi feita com sucesso",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                UpdateListView();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao editar usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}