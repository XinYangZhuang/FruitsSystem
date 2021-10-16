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
  public  class CartBusiness
    {
      public static int InsertCart(Cart c)
      {
          string cmdText = "insert into tb_cart values(@UserId,@FruitId,@quantity ) ";
          string[] names = { "@UserId", "@FruitId", "@quantity" };
          object[] values = {  c.Userid, c.Fruitid,c.Quantity };
          int i = Convert.ToInt32(DA.ExcuteSql2(cmdText, names, values));
          return i;
      }


      public static DataTable ShowCart(string userid)
      {
          DataSet ds;
          string cmdText = "select fruits.F_Name,quantity*F_Price as total_price,tb_cart.* from tb_cart,fruits where  tb_cart.fruitid=fruits.id and tb_cart.userid=@userid ";
          string[] paras = { "@userid" };
          object[] values = { userid };
          ds = DA.ExcuteSql4(cmdText, paras, values);
          DataTable dt = ds.Tables["table"];
          return dt;
      }


      public static int DeleteCart(string cartid)
      {
          string cmdText = "delete from  tb_cart where Id=@cartid";
          string[] names = { "@cartid" };
          object[] values = { cartid };
          int i = Convert.ToInt32(DA.ExcuteSql2(cmdText, names, values));
          return i;
      }


      public static object[] SearchCartInfo(string cid)
      {
          string cmdText = "select fruits.F_Name,quantity*F_Price as total_price,F_Price,F_Image,F_Count,tb_cart.* from tb_cart,fruits where  tb_cart.fruitid=fruits.id and tb_cart.id=@cid;";
          string[] names = { "@cid" };
          string[] values = { cid };
          object[] obj = DA.ExcuteSql3(cmdText, names, values);
          return obj;
      }





    }
}
