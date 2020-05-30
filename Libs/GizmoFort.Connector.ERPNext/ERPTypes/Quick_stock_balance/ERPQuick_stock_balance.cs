using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quick_stock_balance
{
    public class ERPQuick_stock_balance : ERPNextObjectBase
    {
        public ERPQuick_stock_balance() : this(new ERPObject(DocType.Quick_stock_balance)) { }
        public ERPQuick_stock_balance(ERPObject obj) : base(obj) { }

        public static ERPQuick_stock_balance Create(string warehouse, string item, string date)

        {
            ERPQuick_stock_balance obj = new ERPQuick_stock_balance();
            obj.warehouse = warehouse;
            obj.item = item;
            obj.date = date;
            return obj;
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set
            {
                data.warehouse = value;
                data.name = value;
            }

        }

        public string item
        {
            get { return data.item; }
            set { data.item = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string item_barcode
        {
            get { return data.item_barcode; }
            set { data.item_barcode = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string item_description
        {
            get { return data.item_description; }
            set { data.item_description = value; }
        }

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public double value
        {
            get { return data.value; }
            set { data.value = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }


    }

    //Enums go here

}