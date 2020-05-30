using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_reconciliation_item
{
    public class ERPStock_reconciliation_item : ERPNextObjectBase
    {
        public ERPStock_reconciliation_item() : this(new ERPObject(DocType.Stock_reconciliation_item)) { }
        public ERPStock_reconciliation_item(ERPObject obj) : base(obj) { }

        public static ERPStock_reconciliation_item Create(string itemcode, string warehouse)

        {
            ERPStock_reconciliation_item obj = new ERPStock_reconciliation_item();
            obj.item_code = itemcode;
            obj.warehouse = warehouse;
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

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string barcode
        {
            get { return data.barcode; }
            set { data.barcode = value; }
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

        private double _valuation_rate = 0.0;
        public double valuation_rate
        {
            get { return data._valuation_rate; }
            set { data._valuation_rate = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        private double _current_qty = 0.0;
        public double current_qty
        {
            get { return data._current_qty; }
            set { data._current_qty = value; }
        }

        public string current_serial_no
        {
            get { return data.current_serial_no; }
            set { data.current_serial_no = value; }
        }

        private double _current_valuation_rate = 0.0;
        public double current_valuation_rate
        {
            get { return data._current_valuation_rate; }
            set { data._current_valuation_rate = value; }
        }

        private double _current_amount = 0.0;
        public double current_amount
        {
            get { return data._current_amount; }
            set { data._current_amount = value; }
        }

        public string quantity_difference
        {
            get { return data.quantity_difference; }
            set { data.quantity_difference = value; }
        }

        private double _amount_difference = 0.0;
        public double amount_difference
        {
            get { return data._amount_difference; }
            set { data._amount_difference = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }


    }

    //Enums go here

}