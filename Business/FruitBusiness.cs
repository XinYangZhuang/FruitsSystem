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
    public static class FruitBusiness
    {
        #region Fruits

        public static DataTable ShowFruitTable()
        {
            DataSet ds;
            string cmdText = "select Id,F_Name,F_Class,F_Price,F_Image,F_Info,F_CreateTime,F_Count from [Fruits] ";
            string[] names = { };
            string[] values = { };
            ds = DA.ExcuteSql4(cmdText, names, values);
            DataTable dt = ds.Tables["table"];
            return dt;
        }

        public static DataTable ShowHotFruit()
        {
            DataSet ds;
            string cmdText = "select * from Fruits_hot";
            string[] names = { };
            string[] values = { };
            ds = DA.ExcuteSql4(cmdText, names, values);
            DataTable dt = ds.Tables["table"];
            return dt;
        }

        public static DataTable ShowAllFriitTable()
        {
            DataSet ds;
            string cmdText = "select * from Fruits";
            string[] names = { };
            string[] values = { };
            ds = DA.ExcuteSql4(cmdText, names, values);
            DataTable dt = ds.Tables["table"];
            return dt;
        }


        public static int deleteFruit(int Id)
        {
            string cmdText = "delete  from [Fruits] Where Id=@Id ";
            string[] names = { "@Id" };
            object[] values = { Id };
            int i = Convert.ToInt32(DA.ExcuteSql2(cmdText, names, values));
            return i;
        }

        public static int deletHotFruit(string Id)
        {
            string cmdText = "delete  from [Fruits_hot] Where Id=@Id ";
            string[] names = { "@Id" };
            object[] values = { Id };
            int i = Convert.ToInt32(DA.ExcuteSql2(cmdText, names, values));
            return i;
        }




        public static int InsertFruit(Fruits fruit)
        {
            string cmdText = "insert into Fruits values(@F_Name,@F_Class,@F_Price,@F_Image,@F_Info,@F_CreateTime,@F_Count) ";//防止数据库注入
            string[] names = { "@F_Name", "@F_Class", "@F_Price", "@F_Image", "@F_Info", "@F_CreateTime", "@F_Count" };
            object[] values = { fruit.F_Name, fruit.F_Class, fruit.F_Price, fruit.F_Image, fruit.F_Info, fruit.F_CreateTime, fruit.F_Count };
            int i = DA.ExcuteSql2(cmdText, names, values);
            return i;
        }
        public static object[] SearchFruitById(string Id)
        {
            string cmdText = "select Id,F_Name,F_Class,F_Price,F_Image,F_Info,F_CreateTime,F_Count from [Fruits] where Id=@Id";
            string[] names = { "@Id" };
            string[] values = { Id };
            object[] obj = DA.ExcuteSql3(cmdText, names, values);
            return obj;
        }







        public static int UpdataFruit(Fruits fruit)
        {
            string cmdText = "update [Fruits] Set F_Name=@F_Name,F_Class=@F_Class,F_Price=@F_Price,F_Image=@F_Image,F_Info=@F_Info,F_CreateTime=@F_CreateTime,F_Count=@F_Count Where Id=@Id ";
            string[] names = { "@Id", "@F_Name", "@F_Class", "@F_Price", "@F_Image", "@F_Info", "@F_CreateTime", "@F_Count" };
            object[] values = { fruit.Id, fruit.F_Name, fruit.F_Class, fruit.F_Price, fruit.F_Image, fruit.F_Info, fruit.F_CreateTime, fruit.F_Count };
            int i = Convert.ToInt32(DA.ExcuteSql2(cmdText, names, values));
            return i;
        }

        public static int InsertHot(string id)
        {
            string cmdText = "insert into Fruits_hot select F_Name,F_Class,F_Price,F_Image,F_Info,F_CreateTime,F_Count,@Id from Fruits where Id=@Id";
            string[] names = { "@Id"};
            object[] values = { id };
            int i = Convert.ToInt32(DA.ExcuteSql2(cmdText, names, values));
            return i;
        }



      


        #endregion
    }
}
