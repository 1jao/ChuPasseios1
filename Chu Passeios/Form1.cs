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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Cadastro";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string name = (string)dr["Nome"];
                    string email = (string)dr["Email"];
                    string Senha = (string)dr["Senha"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(Senha);
                    listView1.Items.Add(lv);

                    UpdateListView();

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

        private void lblpassword_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btmenter_Click(object sender, EventArgs e)
        {
            string name= textBox1.Text,email= textBox2.Text,senha= textBox3.Text;
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"INSERT INTO Cadastro_Cliente VALUES(@NAME,@EMAIL,@PASSWORD)";
            sqlCom.Parameters.AddWithValue("@NAME", textBox1.Text);
            sqlCom.Parameters.AddWithValue("@EMAIL", textBox2.Text);
            sqlCom.Parameters.AddWithValue("@PASSWORD", textBox3.Text);
            sqlCom.ExecuteNonQuery();


        }
    }
}
