using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_ledger_entry
{
    public class ERPStock_ledger_entry : ERPNextObjectBase
    {
        public ERPStock_ledger_entry() : this(new ERPObject(DocType.Stock_ledger_entry)) { }
        public ERPStock_ledger_entry(ERPObject obj) : base(obj) { }

        public static ERPStock_ledger_entry Create()

        {
            ERPStock_ledger_entry obj = new ERPStock_ledger_entry();
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

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string posting_time
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
        }

        public string voucher_type
        {
            get { return data.voucher_type; }
            set { data.voucher_type = value; }
        }

        public string voucher_no
        {
            get { return data.voucher_no; }
            set { data.voucher_no = value; }
        }

        public string voucher_detail_no
        {
            get { return data.voucher_detail_no; }
            set { data.voucher_detail_no = value; }
        }

        public double actual_qty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        public double incoming_rate
        {
            get { return data.incoming_rate; }
            set { data.incoming_rate = value; }
        }

        public double outgoing_rate
        {
            get { return data.outgoing_rate; }
            set { data.outgoing_rate = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public double qty_after_transaction
        {
            get { return data.qty_after_transaction; }
            set { data.qty_after_transaction = value; }
        }

        public double valuation_rate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        public double stock_value
        {
            get { return data.stock_value; }
            set { data.stock_value = value; }
        }

        public double stock_value_difference
        {
            get { return data.stock_value_difference; }
            set { data.stock_value_difference = value; }
        }

        public string stock_queue
        {
            get { return data.stock_queue; }
            set { data.stock_queue = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string fiscal_year
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        public long is_cancelled
        {
            get { return data.is_cancelled; }
            set { data.is_cancelled = value; }
        }

        public long to_rename
        {
            get { return data.to_rename; }
            set { data.to_rename = value; }
        }


    }

    //Enums go here

}