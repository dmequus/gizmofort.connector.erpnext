using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_reconciliation_invoice
{
    public class ERPPayment_reconciliation_invoice : ERPNextObjectBase
    {
        public ERPPayment_reconciliation_invoice() : this(new ERPObject(DocType.Payment_reconciliation_invoice)) { }
        public ERPPayment_reconciliation_invoice(ERPObject obj) : base(obj) { }

        public static ERPPayment_reconciliation_invoice Create(Invoicetype invoicetype, string invoicenumber, string invoicedate, double amount, double outstandingamount)

        {
            ERPPayment_reconciliation_invoice obj = new ERPPayment_reconciliation_invoice();
            obj.invoice_type = invoicetype;
            obj.invoice_number = invoicenumber;
            obj.invoice_date = invoicedate;
            obj.amount = amount;
            obj.outstanding_amount = outstandingamount;
            return obj;
        }

        public Invoicetype invoice_type
        {
            get { return parseEnum<Invoicetype>(data.invoice_type); }
            set { data.invoice_type = value.ToString(); }
        }

        public string invoice_number
        {
            get { return data.invoice_number; }
            set { data.invoice_number = value; }
        }

        public string invoice_date
        {
            get { return data.invoice_date; }
            set { data.invoice_date = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public double outstanding_amount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }


    }

    //Enums go here
    public enum Invoicetype
    {
        [Description("Sales Invoice")]
        SalesInvoice,
        [Description("Purchase Invoice")]
        PurchaseInvoice,
        [Description("Journal Entry")]
        JournalEntry,
    }


}