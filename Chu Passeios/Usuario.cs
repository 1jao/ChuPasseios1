using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chu_Passeios
{
    //variáveis utilizadas nas funções do UsuárioDAO 
    internal class Usuario
    {
        private int _id;
        private string _Nome;
        private string _Email;
        private string _Senha;
        private string _cep;
        private string _rua;
        private string _Bairro;
        private string _Numero_casa;
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
        public Usuario(int id, string Rua, string bairro, string numero, string cep)
        {
            Id = id;
            rua = Rua;
            Bairro = bairro;
            Numero = numero;
            CEP = cep;

        }
        public Usuario( string Rua, string bairro, string numero, string cep)
        {
            rua = Rua;
            Bairro = bairro;
            Numero = numero;
            CEP = cep;

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
        public Usuario(
                    string email,
                    string senha
                   )
        {
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
            {
                _Senha = value;
            }
            get { return _Senha; }


        }
        public string rua
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO Rua");

                _rua = value;
            }
            get { return _rua; }

        }
        public string Bairro
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO Bairro");

                _Bairro = value;
            }
            get { return _Bairro; }

        }
        public string Numero
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO Número da Casa");

                _Numero_casa = value;
            }
            get { return _Numero_casa; }

        }
        public string CEP
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO CEP");

                _cep = value;
            }
            get { return _cep; }


        }
    }
}

