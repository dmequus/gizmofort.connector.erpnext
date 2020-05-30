using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Blanket_order_item
{
    public class ERPBlanket_order_item : ERPNextObjectBase
    {
        public ERPBlanket_order_item() : this(new ERPObject(DocType.Blanket_order_item)) { }
        public ERPBlanket_order_item(ERPObject obj) : base(obj) { }

        public static ERPBlanket_order_item Create(string itemcode, double rate)

        {
            ERPBlanket_order_item obj = new ERPBlanket_order_item();
            obj.item_code = itemcode;
            obj.rate = rate;
            return obj;
        }

        public string item_code
        {
            get { return data.item_code; }
            set
            {
                data.item_code = value;
                data.name = value;
            }

        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        private double _ordered_qty = 0.0;
        public double ordered_qty
        {
            get { return data._ordered_qty; }
            set { data._ordered_qty = value; }
        }

        public string terms_and_conditions
        {
            get { return data.terms_and_conditions; }
            set { data.terms_and_conditions = value; }
        }


    }

    //Enums go here

}