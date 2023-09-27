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
            string name = textBox1.Text, email = textBox2.Text, senha = textBox3.Text;
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"INSERT INTO Cadastro_Cliente VALUES(@NAME,@EMAIL,@PASSWORD)";
            sqlCom.Parameters.AddWithValue("@NAME", textBox1.Text);
            sqlCom.Parameters.AddWithValue("@EMAIL", textBox2.Text);
            sqlCom.Parameters.AddWithValue("@PASSWORD", textBox3.Text);
            sqlCom.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso",
                            "AVISO",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            UpdateListView();
        }

 

        private void Table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = Table.FocusedItem.Index;
            id = int.Parse(Table.Items[index].SubItems[0].Text);
            textBox1.Text = Table.Items[index].SubItems[1].Text;
            textBox2.Text = Table.Items[index].SubItems[2].Text;
            textBox3.Text = Table.Items[index].SubItems[3].Text;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            UpdateListView();
        }
        private void Nome_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Border3DStyle.Flat.CompareTo(BorderStyle.None);
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
        }
        private void textm_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = Table.FocusedItem.Index;
            id = int.Parse(Table.Items[index].SubItems[0].Text);
            textBox1.Text = Table.Items[index].SubItems[1].Text;
            textBox2.Text = Table.Items[index].SubItems[2].Text;
            textBox3.Text = Table.Items[index].SubItems[3].Text;
        }

        private void text3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
