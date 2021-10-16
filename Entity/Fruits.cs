using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Fruits
    {
        private int _id;
        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        private string _f_name;
        public string F_Name {
            get { return _f_name; }
            set{_f_name = value;}
        }
        private string _f_class;
        public string F_Class {
            get { return _f_class; }
            set { _f_class = value; }
        }
        private int _f_price;
        public int F_Price {
            get { return _f_price; }
            set { _f_price = value; }
        }
        private string _f_image;
        public string F_Image {
            get { return _f_image; }
            set { _f_image = value; }
        }
        private string _f_info;
        public string F_Info {
            get { return _f_info; }
            set { _f_info = value; }
        }
        private DateTime _f_createTime;
        public DateTime F_CreateTime {
            get { return _f_createTime; }
            set { _f_createTime = value; }
        }
        private int _f_count;
        public int F_Count {
            get { return _f_count; }
            set { _f_count = value; }
        }

    }
}
