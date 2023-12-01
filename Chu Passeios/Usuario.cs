using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chu_Passeios
{
    internal class Usuario
    {
        private int _id;
        private string _Nome;
        private string _Email;
        private string _Senha;

        public Usuario(int id,
                    string nome,
                    string email,
                    string senha
                   )
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public Usuario(
                    string nome,
                    string email,
                    string senha
                   )
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public int Id
        {
            set
            {
                _id = value;
            }
            get { return _id; }
        }


        public string Nome
        {
            set
            {
                
                _Nome = value;
            }
            get { return _Nome; }
        }


        public string Email
        {
            set
            {
                _Email = value;
            }
            get { return _Email; }
        }
        public string Senha
        {
            set
            { _Senha = value;
            }
            get { return _Senha; }


        }

    }
}


