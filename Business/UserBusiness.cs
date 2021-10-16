using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace Business
{
    public class UserBusiness
    {
        #region User
        public static int Login(Users user)
        {
            string cmdtxt = "select count(*) from Users where U_Account=@U_Account and U_PassWord=@U_PassWord";
            string[] names = { "@U_Account", "@U_PassWord" };
            object[] values = { user.U_Account, user.U_PassWord };
            int result = Convert.ToInt32(DA.ExcuteSql1(cmdtxt, names,values));
            return result;
        }

        public static int CheckUserName(string username)
        {
            string cmdtxt = "select count(*) from Users where U_Account=@username ";
            string[] names = { "@username" };
            object[] values = { username };
            int result = Convert.ToInt32(DA.ExcuteSql1(cmdtxt, names, values));
            return result;
        }




        public static object[] SearchUser(Users user)
        {
            string cmdText = "select Id,U_Account,UserName,Sex,Job,Adress,Head from [Users] where U_Account=@U_Account and U_PassWord=@U_PassWord";
            string[] names = { "@U_Account", "@U_PassWord" };
            object[] values = { user.U_Account, user.U_PassWord };
            object[] obj = DA.ExcuteSql3(cmdText, names, values);
            return obj;
        }

        public static object[] SearchUserById(Users user)
        {
            string cmdText = "select Id,U_Account,UserName,Sex,Job,Adress,Head from [Users] where Id=@Id";
            string[] names= { "@Id" };
            object[] values = { user.Id };
            object[] obj = DA.ExcuteSql3(cmdText, names, values);
            return obj;
        }

        public static int Register(Users user)
        {
            string cmdtxt = "insert into Users values(@U_Account,@U_PassWord,@UserName,@Sex,@Job,@Adress,@Head)";
            string[] names = { "@U_Account", "@U_PassWord", "@UserName", "@Sex", "@Job", "@Adress", "@Head" };
            object[] values = { user.U_Account, user.U_PassWord, user.UserName, user.Sex, user.Job, user.Adress, user.Head };
            int result = DA.ExcuteSql2(cmdtxt, names, values);
            return result;
        }
        #endregion

        public static DataTable SearcheUserName(string account)
        {
            DataSet ds;
            string cmdText = " select * from Users where U_Account like '%'+@account+'%' ";
            string[] paras = { "@account" };
            object[] values = { account };
            ds = DA.ExcuteSql4(cmdText, paras, values);
            DataTable dt = ds.Tables["table"];
            return dt;
        }


        public static DataTable ShowUserTable()
        {
            DataSet ds;
            string cmdText = " select * from Users  ";
            //string[] paras = { "@account" };
            //object[] values = { account };
            ds = DA.ExcuteSql4(cmdText, null, null);
            DataTable dt = ds.Tables["table"];
            return dt;
        }


        public static int DeleteUserInfo(string userid)
        {
            string cmdtxt = "delete from users where id=@userid";
            string[] names = { "@userid" };
            object[] values = { userid };
            int result = DA.ExcuteSql2(cmdtxt, names, values);
            return result;
        }



    }
}
