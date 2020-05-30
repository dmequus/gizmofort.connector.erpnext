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

        public double required_qty
        {
            get { return data.required_qty; }
            set { data.required_qty = value; }
        }

        public double transferred_qty
        {
            get { return data.transferred_qty; }
            set { data.transferred_qty = value; }
        }

        public long allow_alternative_item
        {
            get { return data.allow_alternative_item; }
            set { data.allow_alternative_item = value; }
        }

        public long include_item_in_manufacturing
        {
            get { return data.include_item_in_manufacturing; }
            set { data.include_item_in_manufacturing = value; }
        }

        public double consumed_qty
        {
            get { return data.consumed_qty; }
            set { data.consumed_qty = value; }
        }

        public double available_qty_at_source_warehouse
        {
            get { return data.available_qty_at_source_warehouse; }
            set { data.available_qty_at_source_warehouse = value; }
        }

        public double available_qty_at_wip_warehouse
        {
            get { return data.available_qty_at_wip_warehouse; }
            set { data.available_qty_at_wip_warehouse = value; }
        }

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }


    }

    //Enums go here

}