using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_Passeios
{
    public class Usuario
    {
        private int _iD;
        private string _name;
        private string _email;
        private string _password;

        public Usuario(int iD, string name, string EMAIL, string password)
        {

            _iD = iD;
            _name = name;
            _email = EMAIL;
            _password = password;
        }

        public string _ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        public string _nAME
        {
            set { _nAME = value; }
            get { return _nAME; }
        }
        public string _EMAIl
        {
            set { _email = value; }
            get { return _email; }
        }
        public string _passworD
        {
            set { _password = value; }
            get { return _password; }
        }
    }
}


