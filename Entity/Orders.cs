using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Orders
    {
        private int _id;
        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        private int _userid;
        public int UserId {
            get { return _userid; }
            set { _userid = value; }
        }
        private int _friutid;
        public int FruitId {
            get { return _friutid; }
            set { _friutid = value; }
        }
        private string _state;
        public string State {
            get { return _state; }
            set { _state = value; }
        }

        string quantity;

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        string totalprice;

        public string Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }
        string pro;

        public string Pro
        {
            get { return pro; }
            set { pro = value; }
        }
        string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        string receiver;

        public string Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
