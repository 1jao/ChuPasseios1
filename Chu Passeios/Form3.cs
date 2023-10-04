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

namespace Chu_Passeios
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            Table.Items.Clear();
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Cadastro_Cliente";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string name = (string)dr["NAME"];
                    string email = (string)dr["Email"];
                    string Senha = (string)dr["PASSWORD"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(Senha);
                    Table.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }


        private void btmenter_Click(object sender, EventArgs e)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Cadastro_Cliente SET 
            NAME      = @name, 
            EMAIL =     @email,
            PASSWORD  = @pass, 
            WHERE ID   = @id";

            sqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@email", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@senha", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@id", textBox4.Text);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            UpdateListView();


        }

        private void btmdel_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuario = new UsuarioDAO();
            UsuarioDAO.deleteUser(ID);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
