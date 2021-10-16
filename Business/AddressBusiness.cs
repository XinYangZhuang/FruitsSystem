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
  public  class AddressBusiness
    {
        public static DataTable GetProvincesTable()//获取 datatable 
        {
            DataSet ds;
            string cmdText = "select *from tb_Provinces";
            //string[] paras = { "@Id" };
            //object[] values = { Id };
            ds = DA.ExcuteSql4(cmdText, null, null);
            DataTable dt = ds.Tables["table"];
            return dt;
        }

        public static DataTable GetCityTable(string province)//获取 datatable 
        {
            DataSet ds;
            string cmdText = "select *from tb_Cities where provinceId=@provinceId";
            string[] paras = { "@provinceId" };
            object[] values = { province };
            ds = DA.ExcuteSql4(cmdText, paras, values);
            DataTable dt = ds.Tables["table"];
            return dt;
        }

        public static DataTable GetAreaTable(string cityId)//获取 datatable 
        {
            DataSet ds;
            string cmdText = "select *from tb_Areas where cityId=@cityId";
            string[] paras = { "@cityId" };
            object[] values = { cityId };
            ds = DA.ExcuteSql4(cmdText, paras, values);
            DataTable dt = ds.Tables["table"];
            return dt;
        }

        public static int InsertAddress(Address a)
        {
            string cmdtxt = "insert into tb_address values(@pro,@city,@area,@address,@rece,@phone,@userid )";
            string[] names = { "@pro", "@city", "@area", "@address", "@rece", "@phone", "@userid" };
            object[] values = { a.Pro, a.City, a.Area, a.Address1, a.Rece, a.Phone, a.Userid };
            int result = DA.ExcuteSql2(cmdtxt, names, values);
            return result;
        }

        public static DataTable GetAddressByUserid(string userid)//获取 datatable 
        {
            DataSet ds;
            string cmdText = "select * from [tb_address] where userid=@userid";
            string[] paras = { "@userid" };
            object[] values = { userid };
            ds = DA.ExcuteSql4(cmdText, paras, values);
            DataTable dt = ds.Tables["table"];
            return dt;
        }


        public static int DeleteAddressByID(string ID)
        {
            string cmdtxt = "delete from tb_address where addressID=@ID";
            string[] names = { "@ID" };
            object[] values = { ID };
            int result = DA.ExcuteSql2(cmdtxt, names, values);
            return result;
        }


        public static object[] SearchAddress(string Id)
        {
            string cmdText = "select * from tb_address where addressID=@Id";
            string[] names = { "@Id" };
            string[] values = { Id };
            object[] obj = DA.ExcuteSql3(cmdText, names, values);
            return obj;
        }

    }
}
