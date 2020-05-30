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

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public double valuation_rate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        public double current_qty
        {
            get { return data.current_qty; }
            set { data.current_qty = value; }
        }

        public string current_serial_no
        {
            get { return data.current_serial_no; }
            set { data.current_serial_no = value; }
        }

        public double current_valuation_rate
        {
            get { return data.current_valuation_rate; }
            set { data.current_valuation_rate = value; }
        }

        public double current_amount
        {
            get { return data.current_amount; }
            set { data.current_amount = value; }
        }

        public string quantity_difference
        {
            get { return data.quantity_difference; }
            set { data.quantity_difference = value; }
        }

        public double amount_difference
        {
            get { return data.amount_difference; }
            set { data.amount_difference = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }


    }

    //Enums go here

}