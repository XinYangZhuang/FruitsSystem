using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Users
    {
        private int _id;
        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        private string _u_account;
        public string U_Account {
            get { return _u_account; }
            set { _u_account = value; }
        }
        private string _u_password;
        public string U_PassWord {
            get { return _u_password; }
            set { _u_password = value; }
        }
        private string _username;
        public string UserName {
            get { return _username; }
            set { _username = value; }
        }
        private string _sex;
        public string Sex {
            get { return _sex; }
            set { _sex = value; }
        }
        private string _job;
        public string Job {
            get { return _job; }
            set { _job = value; }
        }
        private string _adress;
        public string Adress {
            get { return _adress; }
            set { _adress = value; }
        }
        private string _head;
        public string Head {
            get { return _head; }
            set { _head = value; }
        }

    }
}
