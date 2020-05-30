using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pick_list_item
{
    public class ERPPick_list_item : ERPNextObjectBase
    {
        public ERPPick_list_item() : this(new ERPObject(DocType.Pick_list_item)) { }
        public ERPPick_list_item(ERPObject obj) : base(obj) { }

        public static ERPPick_list_item Create(string itemcode)

        {
            ERPPick_list_item obj = new ERPPick_list_item();
            obj.item_code = itemcode;
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

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        private double _picked_qty = 0.0;
        public double picked_qty
        {
            get { return data._picked_qty; }
            set { data._picked_qty = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
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

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        private double _conversion_factor = 0.0;
        public double conversion_factor
        {
            get { return data._conversion_factor; }
            set { data._conversion_factor = value; }
        }

        private double _stock_qty = 0.0;
        public double stock_qty
        {
            get { return data._stock_qty; }
            set { data._stock_qty = value; }
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        public string sales_order_item
        {
            get { return data.sales_order_item; }
            set { data.sales_order_item = value; }
        }

        public string material_request
        {
            get { return data.material_request; }
            set { data.material_request = value; }
        }

        public string material_request_item
        {
            get { return data.material_request_item; }
            set { data.material_request_item = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }


    }

    //Enums go here

}