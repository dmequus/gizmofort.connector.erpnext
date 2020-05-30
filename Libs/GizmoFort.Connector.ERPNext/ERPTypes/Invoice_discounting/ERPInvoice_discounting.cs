using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Invoice_discounting
{
    public class ERPInvoice_discounting : ERPNextObjectBase
    {
        public ERPInvoice_discounting() : this(new ERPObject(DocType.Invoice_discounting)) { }
        public ERPInvoice_discounting(ERPObject obj) : base(obj) { }

        public static ERPInvoice_discounting Create(string postingdate, string company, string invoices, string shorttermloan, string bankaccount, string bankchargesaccount, string accountsreceivablecredit, string accountsreceivablediscounted, string accountsreceivableunpaid)

        {
            ERPInvoice_discounting obj = new ERPInvoice_discounting();
            obj.posting_date = postingdate;
            obj.company = company;
            obj.invoices = invoices;
            obj.short_term_loan = shorttermloan;
            obj.bank_account = bankaccount;
            obj.bank_charges_account = bankchargesaccount;
            obj.accounts_receivable_credit = accountsreceivablecredit;
            obj.accounts_receivable_discounted = accountsreceivablediscounted;
            obj.accounts_receivable_unpaid = accountsreceivableunpaid;
            return obj;
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set
            {
                data.posting_date = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string invoices
        {
            get { return data.invoices; }
            set { data.invoices = value; }
        }

        public string short_term_loan
        {
            get { return data.short_term_loan; }
            set { data.short_term_loan = value; }
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }

        public string bank_charges_account
        {
            get { return data.bank_charges_account; }
            set { data.bank_charges_account = value; }
        }

        public string accounts_receivable_credit
        {
            get { return data.accounts_receivable_credit; }
            set { data.accounts_receivable_credit = value; }
        }

        public string accounts_receivable_discounted
        {
            get { return data.accounts_receivable_discounted; }
            set { data.accounts_receivable_discounted = value; }
        }

        public string accounts_receivable_unpaid
        {
            get { return data.accounts_receivable_unpaid; }
            set { data.accounts_receivable_unpaid = value; }
        }

        public string loan_start_date
        {
            get { return data.loan_start_date; }
            set { data.loan_start_date = value; }
        }

        public int loan_period
        {
            get { return data.loan_period; }
            set { data.loan_period = value; }
        }

        public string loan_end_date
        {
            get { return data.loan_end_date; }
            set { data.loan_end_date = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public double total_amount
        {
            get { return data.total_amount; }
            set { data.total_amount = value; }
        }

        public double bank_charges
        {
            get { return data.bank_charges; }
            set { data.bank_charges = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Sanctioned")]
        Sanctioned,
        [Description("Disbursed")]
        Disbursed,
        [Description("Settled")]
        Settled,
        [Description("Cancelled")]
        Cancelled,
    }


}