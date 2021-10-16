using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Admins
    {
        private int _iD;
        public int Id
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _a_Account;
        public string A_Account
        {
            get { return _a_Account; }
            set { _a_Account = value; }
        }
        private string _a_Password;

        public string A_PassWord
        {
            get { return _a_Password; }
            set { _a_Password = value; }
        }
        private int _role;
        public int Role
        {
            get { return _role; }
            set { _role = value; }
        }

    }
}