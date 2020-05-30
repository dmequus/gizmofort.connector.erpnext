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

        public int qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public int served
        {
            get { return data.served; }
            set { data.served = value; }
        }

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }


    }

    //Enums go here

}