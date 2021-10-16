using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using DataAccess;
using Entity;

namespace Business
{
    public static class OrderBusiness
    {

        public static DataTable ShowUserOrder(int Id)
        {
            DataSet ds;
            string cmdText = "select * from [Orders],[Users],[Fruits] Where Orders.UserId=Users.Id and Fruits.Id=Orders.FruitId and Users.Id=@Id";
            string[] paras = { "@Id" };
            object[] values = { Id };
            ds = DA.ExcuteSql4(cmdText, paras, values);
            DataTable dt = ds.Tables["table"];
            return dt;
        }


        public static DataTable SelectAllOrder()
        {
            DataSet ds;
            string cmdText = "select * from [Orders],[Users],[Fruits] Where Orders.UserId=Users.Id and Fruits.Id=Orders.FruitId";
            //string[] paras = { "@Id" };
            //object[] values = { Id };
            ds = DA.ExcuteSql4(cmdText, null, null);
            DataTable dt = ds.Tables["table"];
            return dt;
        }

        public static DataTable SelectOrderByOrderid(string orderid)
        {
            DataSet ds;
            string cmdText = "select * from [Orders],[Users],[Fruits] Where Orders.UserId=Users.Id and Fruits.Id=Orders.FruitId and orders.Id like '%'+@Id+'%'";
            string[] paras = { "@Id" };
            object[] values = { orderid };
            ds = DA.ExcuteSql4(cmdText, paras, values);
            DataTable dt = ds.Tables["table"];
            return dt;
        }




        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static int DeleteOrder(int Id)
        {
            string cmdText = "delete  from [Orders] Where Id=@Id ";
            string[] names = { "@Id" };
            object[] values = { Id };
            int i = Convert.ToInt32(DA.ExcuteSql2(cmdText, names, values));
            return i;
        }

        /// <summary>
        /// 插入订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static int InsertOrder(Orders orders)
        {
            string cmdText = "insert into Orders values(@UserId,@FruitId,@State,@quantity,@totalprice,@pro,@city,@area,@address,@receiver,@phone )";
            string[] names = { "@UserId", "@FruitId", "@State", "@quantity", "@totalprice", "@pro", "@city", "@area", "@address", "@receiver","@phone" };
            object[] values = { orders.UserId, orders.FruitId, orders.State, orders.Quantity, orders.Totalprice, orders.Pro, orders.City, orders.Area, orders.Address,orders.Receiver,orders.Phone };
            int i = DA.ExcuteSql2(cmdText, names, values);
            return i;
        }



        public static int UpdateStock(string fid,int quantity)
        {
            string cmdText = "update Fruits set F_Count=F_Count-@quantity where Id=@fid";
            string[] names = { "@fid", "@quantity" };
            object[] values = { fid, quantity};
            int i = DA.ExcuteSql2(cmdText, names, values);
            return i;
        }



        public static object[] SearchOrderDetail(string oid)
        {
            string cmdText = "select orders.*,F_Name from orders,Fruits where orders.FruitId=Fruits.Id and  orders.Id=@oid";
            string[] names = { "@oid" };
            string[] values = { oid };
            object[] obj = DA.ExcuteSql3(cmdText, names, values);
            return obj;
        }


        public static int UpdateOrderState(string orderid,string state)
        {
            string cmdText = "update orders set state=@state where id=@orderid";
            string[] names = { "@state", "@orderid" };
            object[] values = { state, orderid };
            int i = DA.ExcuteSql2(cmdText, names, values);
            return i;
        }

    }
}
