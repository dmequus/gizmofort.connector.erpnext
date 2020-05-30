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

        private double _required_qty = 0.0;
        public double required_qty
        {
            get { return data._required_qty; }
            set { data._required_qty = value; }
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

        private double _conversion_factor = 0.0;
        public double conversion_factor
        {
            get { return data._conversion_factor; }
            set { data._conversion_factor = value; }
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

        private double _supplied_qty = 0.0;
        public double supplied_qty
        {
            get { return data._supplied_qty; }
            set { data._supplied_qty = value; }
        }


    }

    //Enums go here

}