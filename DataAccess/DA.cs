using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public  static class DA
    {
        static SqlConnection myConn;
        static SqlCommand scd;
        static SqlDataAdapter sda;
        static SqlDataReader sdr;
        static DataSet ds = new DataSet();
        static DA()
        {
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["FruitSqlDbConn"].ConnectionString;
            scd = new SqlCommand();
            scd.Connection = myConn;
            sda = new SqlDataAdapter();
        }

        public static object ExcuteSql1(string cmdText, string[] paraNames, object[] paraValues)
        {
            scd.CommandText = cmdText;
            scd.Parameters.Clear();
            if (myConn.State != ConnectionState.Open)
                myConn.Open();
          if (paraNames != null)
            {
              
                for (int i = 0; i < paraNames.Length; i++)
                    scd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
            }
            var result = scd.ExecuteScalar();
            myConn.Close();
            return result;
        }

        public static int ExcuteSql2(string cmdText, string[] paraNames, object[] paraValues)
        {
            scd.CommandText = cmdText;
            scd.Parameters.Clear();
            if (myConn.State != ConnectionState.Open)
                myConn.Open();
            if (paraNames != null)
            {
                for (int i = 0; i < paraNames.Length; i++)
                    scd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
            }
            int result = scd.ExecuteNonQuery();
            myConn.Close();
            return result;
        }

        public static object[] ExcuteSql3(string cmdText, string[] paraNames, object[] paraValues)
        {
            scd.CommandText = cmdText;
            scd.Parameters.Clear();
            if (myConn.State != ConnectionState.Open)
                myConn.Open();
            if (paraNames != null)
            {
                for (int i = 0; i < paraNames.Length; i++)
                    scd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
            }
            sdr = scd.ExecuteReader();
            object[] obj = new object[sdr.FieldCount];
            if (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    obj[i] = sdr.GetValue(i);
                }
            }
            myConn.Close();
            return obj;
        }

        public static DataSet ExcuteSql4(string cmdText, string[] paraNames, object[] paraValues)
        {
            scd.CommandText = cmdText; 
            ds.Clear();
            scd.Parameters.Clear();
            if (myConn.State != ConnectionState.Open)
                myConn.Open();
            if (paraNames != null)
            {
                for (int i = 0; i < paraNames.Length; i++)
                    scd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
            }
            sda.SelectCommand = scd;
            sda.Fill(ds, "table");
            myConn.Close();
            return ds;
        }

    }
}
