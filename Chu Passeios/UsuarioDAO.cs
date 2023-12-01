using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
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
        public void insertUsuario(Usuario usuario)
        {
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"INSERT INTO Cadastro_Cliente VALUES(@NAME,@EMAIL,@PASSWORD)";
            sqlCom.Parameters.AddWithValue("@NAME", usuario.Nome);
            sqlCom.Parameters.AddWithValue("@EMAIL", usuario.Email);
            sqlCom.Parameters.AddWithValue("@PASSWORD", usuario.Senha);
            sqlCom.ExecuteNonQuery();
        }
        public void updateUsuario(Usuario usuario)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Cadastro_Cliente SET 
    NAME      = @name, 
    EMAIL =     @email,
    PASSWORD  = @pass, 
    WHERE ID   = @id";

            sqlCommand.Parameters.AddWithValue("@name", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@pass", usuario.Senha);
            sqlCommand.Parameters.AddWithValue("@id", usuario.Id);

            sqlCommand.ExecuteNonQuery();
        }

        public bool LoginUsuario(string email, string password)
        {
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"SELECT * FROM Cadastro_Cliente WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD";
            sqlCom.Parameters.AddWithValue("@EMAIL", email);
            sqlCom.Parameters.AddWithValue("@PASSWORD", password);

            SqlDataReader reader = sqlCom.ExecuteReader();

            if (reader.HasRows)
            {
                return true; // Login successful
            }
            else
            {
                return false; // Login failed
            }
        }

    }
}

