using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_invoice_item
{
    public class ERPBank_statement_transaction_invoice_item : ERPNextObjectBase
    {
        public ERPBank_statement_transaction_invoice_item() : this(new ERPObject(DocType.Bank_statement_transaction_invoice_item)) { }
        public ERPBank_statement_transaction_invoice_item(ERPObject obj) : base(obj) { }

        public static ERPBank_statement_transaction_invoice_item Create(string transactiondate, string paymentdescription, Partytype partytype, string party, string invoicedate, Invoicetype invoicetype, string invoice, string outstandingamount, string allocatedamount)

        {
            ERPBank_statement_transaction_invoice_item obj = new ERPBank_statement_transaction_invoice_item();
            obj.transaction_date = transactiondate;
            obj.payment_description = paymentdescription;
            obj.party_type = partytype;
            obj.party = party;
            obj.invoice_date = invoicedate;
            obj.invoice_type = invoicetype;
            obj.invoice = invoice;
            obj.outstanding_amount = outstandingamount;
            obj.allocated_amount = allocatedamount;
            return obj;
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set
            {
                data.transaction_date = value;
                data.name = value;
            }

        }

        public string payment_description
        {
            get { return data.payment_description; }
            set { data.payment_description = value; }
        }

        public Partytype party_type
        {
            get { return parseEnum<Partytype>(data.party_type); }
            set { data.party_type = value.ToString(); }
        }

        public string party
        {
            get { return data.party; }
            set { data.party = value; }
        }

        public string invoice_date
        {
            get { return data.invoice_date; }
            set { data.invoice_date = value; }
        }

        public Invoicetype invoice_type
        {
            get { return parseEnum<Invoicetype>(data.invoice_type); }
            set { data.invoice_type = value.ToString(); }
        }

        public string invoice
        {
            get { return data.invoice; }
            set { data.invoice = value; }
        }

        public string outstanding_amount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }

        public string allocated_amount
        {
            get { return data.allocated_amount; }
            set { data.allocated_amount = value; }
        }


    }

    //Enums go here
    public enum Partytype
    {
        [Description("Customer")]
        Customer,
        [Description("Supplier")]
        Supplier,
        [Description("Account")]
        Account,
    }

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