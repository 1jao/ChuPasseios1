using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_Passeios
{
    internal class UsuarioDAO

    {
        public void deleteUser(int ID)
        {
            //Código para excluir
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Cadastro_Cliente WHERE ID = @ID";
            sqlCommand.Parameters.AddWithValue("@id", ID);
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

    } 

    }

