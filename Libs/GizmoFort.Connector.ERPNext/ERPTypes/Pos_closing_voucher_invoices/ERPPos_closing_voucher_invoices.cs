using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher_invoices
{
    public class ERPPos_closing_voucher_invoices : ERPNextObjectBase
    {
        public ERPPos_closing_voucher_invoices() : this(new ERPObject(DocType.Pos_closing_voucher_invoices)) { }
        public ERPPos_closing_voucher_invoices(ERPObject obj) : base(obj) { }

        public static ERPPos_closing_voucher_invoices Create(string invoice, string qtyofitems, double grandtotal)

        {
            ERPPos_closing_voucher_invoices obj = new ERPPos_closing_voucher_invoices();
            obj.invoice = invoice;
            obj.qty_of_items = qtyofitems;
            obj.grand_total = grandtotal;
            return obj;
        }

        public string invoice
        {
            get { return data.invoice; }
            set
            {
                data.invoice = value;
                data.name = value;
            }

        }

        public string qty_of_items
        {
            get { return data.qty_of_items; }
            set { data.qty_of_items = value; }
        }

        public double grand_total
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
        }


    }

    //Enums go here

}