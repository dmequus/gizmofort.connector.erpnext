using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_payment_item
{
    public class ERPBank_statement_transaction_payment_item : ERPNextObjectBase
    {
        public ERPBank_statement_transaction_payment_item() : this(new ERPObject(DocType.Bank_statement_transaction_payment_item)) { }
        public ERPBank_statement_transaction_payment_item(ERPObject obj) : base(obj) { }

        public static ERPBank_statement_transaction_payment_item Create(string transactiondate, string description, double amount, Partytype partytype, string party, Referencetype referencetype, string account, string modeofpayment, double outstandingamount, string referencename, string paymentreference, string invoices)

        {
            ERPBank_statement_transaction_payment_item obj = new ERPBank_statement_transaction_payment_item();
            obj.transaction_date = transactiondate;
            obj.description = description;
            obj.amount = amount;
            obj.party_type = partytype;
            obj.party = party;
            obj.reference_type = referencetype;
            obj.account = account;
            obj.mode_of_payment = modeofpayment;
            obj.outstanding_amount = outstandingamount;
            obj.reference_name = referencename;
            obj.payment_reference = paymentreference;
            obj.invoices = invoices;
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

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
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

        public Referencetype reference_type
        {
            get { return parseEnum<Referencetype>(data.reference_type); }
            set { data.reference_type = value.ToString(); }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        private double _outstanding_amount = 0.0;
        public double outstanding_amount
        {
            get { return data._outstanding_amount; }
            set { data._outstanding_amount = value; }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string payment_reference
        {
            get { return data.payment_reference; }
            set { data.payment_reference = value; }
        }

        public string invoices
        {
            get { return data.invoices; }
            set { data.invoices = value; }
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

    public enum Referencetype
    {
        [Description("Payment Entry")]
        PaymentEntry,
        [Description("Journal Entry")]
        JournalEntry,
    }


}