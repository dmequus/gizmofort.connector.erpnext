using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_order_entry
{
    public class ERPRestaurant_order_entry : ERPNextObjectBase
    {
        public ERPRestaurant_order_entry() : this(new ERPObject(DocType.Restaurant_order_entry)) { }
        public ERPRestaurant_order_entry(ERPObject obj) : base(obj) { }

        public static ERPRestaurant_order_entry Create(string restauranttable, string additem, double grandtotal, string lastsalesinvoice, string items)

        {
            ERPRestaurant_order_entry obj = new ERPRestaurant_order_entry();
            obj.restaurant_table = restauranttable;
            obj.add_item = additem;
            obj.grand_total = grandtotal;
            obj.last_sales_invoice = lastsalesinvoice;
            obj.items = items;
            return obj;
        }

        public string restaurant_table
        {
            get { return data.restaurant_table; }
            set
            {
                data.restaurant_table = value;
                data.name = value;
            }

        }

        public string add_item
        {
            get { return data.add_item; }
            set { data.add_item = value; }
        }

        private double _grand_total = 0.0;
        public double grand_total
        {
            get { return data._grand_total; }
            set { data._grand_total = value; }
        }

        public string last_sales_invoice
        {
            get { return data.last_sales_invoice; }
            set { data.last_sales_invoice = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }


    }

    //Enums go here

}