using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cart
    {
        string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
       
        string UserId;
        public string Userid
        {
            get { return UserId; }
            set { UserId = value; }
        }
        string FruitId;
        public string Fruitid
        {
            get { return FruitId; }
            set { FruitId = value; }
        }
        string quantity;

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
       

    }
}
