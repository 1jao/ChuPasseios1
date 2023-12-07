using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chu_Passeios
{
    public partial class Form6 : Form
        //o form6 é responsável pelo cadastro de endereço 
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            UsuarioDAO usuarioDao = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDao.SelectUsuario1();

            try
            {
                foreach (Usuario usuario in usuarios)
                {
                    ListViewItem lv = new ListViewItem(usuario.Id.ToString());
                    lv.SubItems.Add(usuario.rua);
                    lv.SubItems.Add(usuario.Bairro);
                    lv.SubItems.Add(usuario.Numero);
                    lv.SubItems.Add(usuario.CEP);

                    listView1.Items.Add(lv);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("Rua", "Bairro", "Numero", "CEP");
            usuario.rua = textBox2.Text;
            usuario.Bairro = textBox3.Text;
            usuario.Numero = textBox4.Text;
            usuario.CEP = maskedTextBox1.Text;

            string cep = maskedTextBox1.Text;
            string url = "https://viacep.com.br/ws/" + cep + "/json/";
            //verifica o CEP no site viacep

            using (var client = new WebClient())
            {
                var json = client.DownloadString(url);
                dynamic result = JsonConvert.DeserializeObject(json);

                if (result.erro != null)
                {
                    MessageBox.Show("CEP não encontrado.");
                    return;
                    //se o CEP não existir, o site exibirá a mensagem "CEP não encontrado"
                }
            }

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.InsertUsuario1(usuario);
            //usará uma nova funçao, a insertusuario1
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            UpdateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario( "Rua", "Bairro", "Numero", "CEP");
            usuario.Id = int.Parse(textBox1.Text);
            //pega o ID como referência
            usuario.rua = textBox2.Text;
            usuario.Bairro = textBox3.Text;
            usuario.Numero = textBox4.Text;
            usuario.CEP = maskedTextBox1.Text;

            string cep = maskedTextBox1.Text;
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            using (var client = new WebClient())
            {
                var json = client.DownloadString(url);
                dynamic result = JsonConvert.DeserializeObject(json);

                if (result.erro != null)
                {
                    MessageBox.Show("CEP não encontrado.");
                    return;
                }
            }

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.UpdateUsuario1(usuario);
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            UpdateListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario( "Rua", "Bairro", "Numero", "CEP");
            usuario.Id = int.Parse(textBox1.Text);

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.DeletUsuario1(usuario.Id);
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            UpdateListView();
        }
        //pega ID como referencia e deleta o cadastro

        private void Form6_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
    
}
