using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Work_order_item
{
    public class ERPWork_order_item : ERPNextObjectBase
    {
        public ERPWork_order_item() : this(new ERPObject(DocType.Work_order_item)) { }
        public ERPWork_order_item(ERPObject obj) : base(obj) { }

        public static ERPWork_order_item Create()

        {
            ERPWork_order_item obj = new ERPWork_order_item();
            return obj;
        }

        public string operation
        {
            get { return data.operation; }
            set
            {
                data.operation = value;
                data.name = value;
            }

        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string source_warehouse
        {
            get { return data.source_warehouse; }
            set { data.source_warehouse = value; }
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

        private double _transferred_qty = 0.0;
        public double transferred_qty
        {
            get { return data._transferred_qty; }
            set { data._transferred_qty = value; }
        }

        private int _allow_alternative_item = 0;
        public int allow_alternative_item
        {
            get { return data._allow_alternative_item; }
            set { data._allow_alternative_item = value; }
        }

        private int _include_item_in_manufacturing = 0;
        public int include_item_in_manufacturing
        {
            get { return data._include_item_in_manufacturing; }
            set { data._include_item_in_manufacturing = value; }
        }

        private double _consumed_qty = 0.0;
        public double consumed_qty
        {
            get { return data._consumed_qty; }
            set { data._consumed_qty = value; }
        }

        private double _available_qty_at_source_warehouse = 0.0;
        public double available_qty_at_source_warehouse
        {
            get { return data._available_qty_at_source_warehouse; }
            set { data._available_qty_at_source_warehouse = value; }
        }

        private double _available_qty_at_wip_warehouse = 0.0;
        public double available_qty_at_wip_warehouse
        {
            get { return data._available_qty_at_wip_warehouse; }
            set { data._available_qty_at_wip_warehouse = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }


    }

    //Enums go here

}