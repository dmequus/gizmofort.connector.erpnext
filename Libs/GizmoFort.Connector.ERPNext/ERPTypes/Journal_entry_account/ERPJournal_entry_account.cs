using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry_account
{
    public class ERPJournal_entry_account : ERPNextObjectBase
    {
        public ERPJournal_entry_account() : this(new ERPObject(DocType.Journal_entry_account)) { }
        public ERPJournal_entry_account(ERPObject obj) : base(obj) { }

        public static ERPJournal_entry_account Create(string account)

        {
            ERPJournal_entry_account obj = new ERPJournal_entry_account();
            obj.account = account;
            return obj;
        }

        public string account
        {
            get { return data.account; }
            set
            {
                data.account = value;
                data.name = value;
            }

        }

        public string account_type
        {
            get { return data.account_type; }
            set { data.account_type = value; }
        }

        public double balance
        {
            get { return data.balance; }
            set { data.balance = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string party_type
        {
            get { return data.party_type; }
            set { data.party_type = value; }
        }

        public string party
        {
            get { return data.party; }
            set { data.party = value; }
        }

        public double party_balance
        {
            get { return data.party_balance; }
            set { data.party_balance = value; }
        }

        public string account_currency
        {
            get { return data.account_currency; }
            set { data.account_currency = value; }
        }

        public double exchange_rate
        {
            get { return data.exchange_rate; }
            set { data.exchange_rate = value; }
        }

        public double debit_in_account_currency
        {
            get { return data.debit_in_account_currency; }
            set { data.debit_in_account_currency = value; }
        }

        public double debit
        {
            get { return data.debit; }
            set { data.debit = value; }
        }

        public double credit_in_account_currency
        {
            get { return data.credit_in_account_currency; }
            set { data.credit_in_account_currency = value; }
        }

        public double credit
        {
            get { return data.credit; }
            set { data.credit = value; }
        }

        public Referencetype reference_type
        {
            get { return parseEnum<Referencetype>(data.reference_type); }
            set { data.reference_type = value.ToString(); }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string reference_due_date
        {
            get { return data.reference_due_date; }
            set { data.reference_due_date = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public Isadvance is_advance
        {
            get { return parseEnum<Isadvance>(data.is_advance); }
            set { data.is_advance = value.ToString(); }
        }

        public string user_remark
        {
            get { return data.user_remark; }
            set { data.user_remark = value; }
        }

        public string against_account
        {
            get { return data.against_account; }
            set { data.against_account = value; }
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }


    }

    //Enums go here
    public enum Referencetype
    {
        [Description("Sales Invoice")]
        SalesInvoice,
        [Description("Purchase Invoice")]
        PurchaseInvoice,
        [Description("Journal Entry")]
        JournalEntry,
        [Description("Sales Order")]
        SalesOrder,
        [Description("Purchase Order")]
        PurchaseOrder,
        [Description("Expense Claim")]
        ExpenseClaim,
        [Description("Asset")]
        Asset,
        [Description("Loan")]
        Loan,
        [Description("Payroll Entry")]
        PayrollEntry,
        [Description("Employee Advance")]
        EmployeeAdvance,
        [Description("Exchange Rate Revaluation")]
        ExchangeRateRevaluation,
        [Description("Invoice Discounting")]
        InvoiceDiscounting,
        [Description("Fees")]
        Fees,
    }

    public enum Isadvance
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }


}