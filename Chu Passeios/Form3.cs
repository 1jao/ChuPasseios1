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
    }
}
