using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_receipt_item_supplied
{
    public class ERPPurchase_receipt_item_supplied : ERPNextObjectBase
    {
        public ERPPurchase_receipt_item_supplied() : this(new ERPObject(DocType.Purchase_receipt_item_supplied)) { }
        public ERPPurchase_receipt_item_supplied(ERPObject obj) : base(obj) { }

        public static ERPPurchase_receipt_item_supplied Create(double consumedqty)

        {
            ERPPurchase_receipt_item_supplied obj = new ERPPurchase_receipt_item_supplied();
            obj.consumed_qty = consumedqty;
            return obj;
        }

        private double _consumed_qty = 0.0;
        public double consumed_qty
        {
            get { return data._consumed_qty; }
            set { data._consumed_qty = value; }
        }

        public string main_item_code
        {
            get { return data.main_item_code; }
            set { data.main_item_code = value; }
        }

        public string rm_item_code
        {
            get { return data.rm_item_code; }
            set { data.rm_item_code = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        private double _required_qty = 0.0;
        public double required_qty
        {
            get { return data._required_qty; }
            set { data._required_qty = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
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

        private double _conversion_factor = 0.0;
        public double conversion_factor
        {
            get { return data._conversion_factor; }
            set { data._conversion_factor = value; }
        }

        private double _current_stock = 0.0;
        public double current_stock
        {
            get { return data._current_stock; }
            set { data._current_stock = value; }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string bom_detail_no
        {
            get { return data.bom_detail_no; }
            set { data.bom_detail_no = value; }
        }


    }

    //Enums go here

}