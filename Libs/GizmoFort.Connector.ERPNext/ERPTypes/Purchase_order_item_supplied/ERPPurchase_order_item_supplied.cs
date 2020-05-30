using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_order_item_supplied
{
    public class ERPPurchase_order_item_supplied : ERPNextObjectBase
    {
        public ERPPurchase_order_item_supplied() : this(new ERPObject(DocType.Purchase_order_item_supplied)) { }
        public ERPPurchase_order_item_supplied(ERPObject obj) : base(obj) { }

        public static ERPPurchase_order_item_supplied Create()

        {
            ERPPurchase_order_item_supplied obj = new ERPPurchase_order_item_supplied();
            return obj;
        }

        public string main_item_code
        {
            get { return data.main_item_code; }
            set
            {
                data.main_item_code = value;
                data.name = value;
            }

        }

        public string rm_item_code
        {
            get { return data.rm_item_code; }
            set { data.rm_item_code = value; }
        }

        public double required_qty
        {
            get { return data.required_qty; }
            set { data.required_qty = value; }
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

        public string bom_detail_no
        {
            get { return data.bom_detail_no; }
            set { data.bom_detail_no = value; }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public double conversion_factor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public string reserve_warehouse
        {
            get { return data.reserve_warehouse; }
            set { data.reserve_warehouse = value; }
        }

        public double supplied_qty
        {
            get { return data.supplied_qty; }
            set { data.supplied_qty = value; }
        }


    }

    //Enums go here

}