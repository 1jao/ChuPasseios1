using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chu_Passeios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //botão de Login
            //pega a função Login no UserDAO
            Usuario usuario = new Usuario("Email","Password");
            usuario.Email = textBox1.Text;
            usuario.Senha = Criptografia.CriptografarSenha(textBox2.Text);

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.loginUsuario(usuario);
        }
    }
}
