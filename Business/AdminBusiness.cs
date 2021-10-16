using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AdminBusiness
    {
        #region Admin
        public static int AdminLogin(Admins admin)
        {
            string cmdtxt = "select Role from Admin where A_Account=@A_Account and A_PassWord=@A_PassWord";
            string[] names = { "@A_Account", "@A_PassWord" };
            object[] values = { admin.A_Account, admin.A_PassWord };
            int result = Convert.ToInt32(DA.ExcuteSql1(cmdtxt, names, values));
            return result;
        }

        #endregion
    }
}
