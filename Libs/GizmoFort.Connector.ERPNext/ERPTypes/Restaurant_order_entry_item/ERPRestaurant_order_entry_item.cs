using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_order_entry_item
{
    public class ERPRestaurant_order_entry_item : ERPNextObjectBase
    {
        public ERPRestaurant_order_entry_item() : this(new ERPObject(DocType.Restaurant_order_entry_item)) { }
        public ERPRestaurant_order_entry_item(ERPObject obj) : base(obj) { }

        public static ERPRestaurant_order_entry_item Create(string item, int qty, int served, double rate)

        {
            ERPRestaurant_order_entry_item obj = new ERPRestaurant_order_entry_item();
            obj.item = item;
            obj.qty = qty;
            obj.served = served;
            obj.rate = rate;
            return obj;
        }

        public string item
        {
            get { return data.item; }
            set
            {
                data.item = value;
                data.name = value;
            }

        }

        private int _qty = 0;
        public int qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        private int _served = 0;
        public int served
        {
            get { return data._served; }
            set { data._served = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }


    }

    //Enums go here

}