using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Chu_Passeios
{
    public partial class Form5 : Form
    {
        private int userId;
        public Form5(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            //userID vem do UsuarioDAO, ele pega a funçao login e manda para este form com seu ID para fazer o relatório
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
            //mostra a picturebox
        {
            pictureBox1.Show();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start > DateTime.Today)
            {
                MessageBox.Show("A viagem foi feito para" + e.Start.ToShortDateString(),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                //quando o usuário clicar em um dia do calendario, ele mostrará o dia em que o usuário irá viajar
            }
            else
            {
                MessageBox.Show("Não é possível viajar para o passado!",
                    "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //se o usuário clicar em um dia que já passou o site mostrará o erro "Não é possível viajar para o passado!"
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ReturnConnection();
            //faz conexão com o banco de dados e retorna conexão

            string query = "SELECT * FROM Cadastro_cliente WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", userId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Document document = new Document();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            PdfWriter.GetInstance(document, new FileStream(path + "/Relatorio.pdf", FileMode.Create));
            document.Open();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    document.Add(new Paragraph(row[column].ToString()));
                }
            }
            document.Close();
            connect.CloseConnection();

            MessageBox.Show("Relatório gerado com sucesso!");
            //faz relatório
            //usei a extensão "Itextsharp" para criar o relatório do usuário que fez o login e envia para a pasta "documentos"
        }

        private void Form5_Load(object sender, EventArgs e)
            //vai esconder o panell1 e o picturebox
        {
            panel1.Hide();
            pictureBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
            //mostra o panell
        {
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
            //leva o usuário ao form6
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
