using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_card_item
{
    public class ERPJob_card_item : ERPNextObjectBase
    {
        public ERPJob_card_item() : this(new ERPObject(DocType.Job_card_item)) { }
        public ERPJob_card_item(ERPObject obj) : base(obj) { }

        public static ERPJob_card_item Create(string itemcode, string sourcewarehouse, string uom, string itemname, string description, double requiredqty, int allowalternativeitem)

        {
            ERPJob_card_item obj = new ERPJob_card_item();
            obj.item_code = itemcode;
            obj.source_warehouse = sourcewarehouse;
            obj.uom = uom;
            obj.item_name = itemname;
            obj.description = description;
            obj.required_qty = requiredqty;
            obj.allow_alternative_item = allowalternativeitem;
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

        public string source_warehouse
        {
            get { return data.source_warehouse; }
            set { data.source_warehouse = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private double _required_qty = 0.0;
        public double required_qty
        {
            get { return data._required_qty; }
            set { data._required_qty = value; }
        }

        private int _allow_alternative_item = 0;
        public int allow_alternative_item
        {
            get { return data._allow_alternative_item; }
            set { data._allow_alternative_item = value; }
        }


    }

    //Enums go here

}