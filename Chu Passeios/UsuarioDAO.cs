using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chu_Passeios
{
    internal class UsuarioDAO
    {
        public List<Usuario> SelectUser()
        {
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Cadastro_cliente";
            //abre conexão com o banco de dados e chama a tabela "Cadastro_cliente"

            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas,3
                //que foram retornadas na consulta, execute.
                while (dr.Read())
                {

                    Usuario objeto = new Usuario(


                    (int)dr["ID"],

                    (string)dr["Name"],

                    (string)dr["Email"],

                    (string)dr["password"]

                    );

                    usuarios.Add(objeto);

                }
                dr.Close();

                return usuarios;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }

        }

        public void deleteUser(int ID)
        {
            //Código para excluir
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Cadastro_Cliente WHERE ID = @ID";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                sqlCommand.ExecuteNonQuery();
            }
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public void insertUsuario(Usuario usuario)
        {
            string email = usuario.Email;
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"INSERT INTO Cadastro_Cliente VALUES(@NAME,@EMAIL,@PASSWORD)";
            sqlCom.Parameters.AddWithValue("@NAME", usuario.Nome);
            sqlCom.Parameters.AddWithValue("@EMAIL", usuario.Email);
            sqlCom.Parameters.AddWithValue("@PASSWORD", usuario.Senha);
            if (IsValidEmail(email) == true)
            {
                sqlCom.ExecuteNonQuery();
                MessageBox.Show("Criado Com Sucesso Seu Cadastro",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email invalido",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        public void updateUsuario(Usuario usuario)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Cadastro_Cliente SET 
             NAME      = @name, 
             EMAIL =     @email,
                PASSWORD  = @pass
                 WHERE ID   = @id";

            sqlCommand.Parameters.AddWithValue("@name", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@pass", usuario.Senha);
            sqlCommand.Parameters.AddWithValue("@id", usuario.Id);

            sqlCommand.ExecuteNonQuery();
        }

        public void loginUsuario(Usuario usuario)
        {

            Connect connect = new Connect();
            SqlConnection connection = connect.ReturnConnection();

            // Consulta SQL para verificar se o usuário existe
            string query = "SELECT ID FROM Cadastro_cliente WHERE Email=@Email AND Password=@Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Password", usuario.Senha);
            int userId = Convert.ToInt32(command.ExecuteScalar());

            if (userId > 0)
            {
                MessageBox.Show("Login feito com sucesso");
                Form5 form5 = new Form5(userId);
                form5.Show();
            }
            else
            {
                MessageBox.Show("Erro ao fazer login");
            }

            connect.CloseConnection();
        }
        public List<Usuario> SelectUsuario1()
        {
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Endereco";
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Usuario objeto = new Usuario(
                    (int)dr["id"],
                    (string)dr["Rua"],
                    (string)dr["Bairro"],
                    (string)dr["Numero_casa"],
                    (string)dr["CEp"]
                    );
                    usuarios.Add(objeto);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro na leitura dos dados\n"
                    + err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return usuarios;
        }
        public void InsertUsuario1(Usuario usuario)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO endereco VALUES 
            (@Rua, @Bairro, @Numero,@CEP)";

            sqlCommand.Parameters.AddWithValue("@Rua", usuario.rua);
            sqlCommand.Parameters.AddWithValue("@Bairro", usuario.Bairro);
            sqlCommand.Parameters.AddWithValue("@Numero", usuario.Numero);
            sqlCommand.Parameters.AddWithValue("@CEP", usuario.CEP);

            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Criado Com Sucesso Seu Cadastro",
            "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);


        }
        public void UpdateUsuario1(Usuario usuario)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE endereco SET 
            Rua = @Rua,
            Bairro = @Bairro,
            Numero_casa = @Numero,
            CEP = @CEP
            WHERE ID = @ID";

            sqlCommand.Parameters.AddWithValue("@Rua", usuario.rua);
            sqlCommand.Parameters.AddWithValue("@Bairro", usuario.Bairro);
            sqlCommand.Parameters.AddWithValue("@Numero", usuario.Numero);
            sqlCommand.Parameters.AddWithValue("@CEP", usuario.CEP);
            sqlCommand.Parameters.AddWithValue("@ID", usuario.Id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("EDITADA COM SUCESSO!",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }
        public void DeletUsuario1(int Id)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM endereco WHERE ID = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Excluido com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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

    }
}

