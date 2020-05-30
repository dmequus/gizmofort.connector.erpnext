using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry
{
    public class ERPJournal_entry : ERPNextObjectBase
    {
        public ERPJournal_entry() : this(new ERPObject(DocType.Journal_entry)) { }
        public ERPJournal_entry(ERPObject obj) : base(obj) { }

        public static ERPJournal_entry Create(string title, Vouchertype vouchertype, string namingseries, string postingdate, string company, string accounts)

        {
            ERPJournal_entry obj = new ERPJournal_entry();
            obj.title = title;
            obj.voucher_type = vouchertype;
            obj.naming_series = namingseries;
            obj.posting_date = postingdate;
            obj.company = company;
            obj.accounts = accounts;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public Vouchertype voucher_type
        {
            get { return parseEnum<Vouchertype>(data.voucher_type); }
            set { data.voucher_type = value.ToString(); }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public string finance_book
        {
            get { return data.finance_book; }
            set { data.finance_book = value; }
        }

        public string cheque_no
        {
            get { return data.cheque_no; }
            set { data.cheque_no = value; }
        }

        public string cheque_date
        {
            get { return data.cheque_date; }
            set { data.cheque_date = value; }
        }

        public string user_remark
        {
            get { return data.user_remark; }
            set { data.user_remark = value; }
        }

        private double _total_debit = 0.0;
        public double total_debit
        {
            get { return data._total_debit; }
            set { data._total_debit = value; }
        }

        private double _total_credit = 0.0;
        public double total_credit
        {
            get { return data._total_credit; }
            set { data._total_credit = value; }
        }

        private double _difference = 0.0;
        public double difference
        {
            get { return data._difference; }
            set { data._difference = value; }
        }

        private int _multi_currency = 0;
        public int multi_currency
        {
            get { return data._multi_currency; }
            set { data._multi_currency = value; }
        }

        public string total_amount_currency
        {
            get { return data.total_amount_currency; }
            set { data.total_amount_currency = value; }
        }

        private double _total_amount = 0.0;
        public double total_amount
        {
            get { return data._total_amount; }
            set { data._total_amount = value; }
        }

        public string total_amount_in_words
        {
            get { return data.total_amount_in_words; }
            set { data.total_amount_in_words = value; }
        }

        public string clearance_date
        {
            get { return data.clearance_date; }
            set { data.clearance_date = value; }
        }

        public string remark
        {
            get { return data.remark; }
            set { data.remark = value; }
        }

        public string paid_loan
        {
            get { return data.paid_loan; }
            set { data.paid_loan = value; }
        }

        public string inter_company_journal_entry_reference
        {
            get { return data.inter_company_journal_entry_reference; }
            set { data.inter_company_journal_entry_reference = value; }
        }

        public string bill_no
        {
            get { return data.bill_no; }
            set { data.bill_no = value; }
        }

        public string bill_date
        {
            get { return data.bill_date; }
            set { data.bill_date = value; }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        public Writeoffbasedon write_off_based_on
        {
            get { return parseEnum<Writeoffbasedon>(data.write_off_based_on); }
            set { data.write_off_based_on = value.ToString(); }
        }

        private double _write_off_amount = 0.0;
        public double write_off_amount
        {
            get { return data._write_off_amount; }
            set { data._write_off_amount = value; }
        }

        public string pay_to_recd_from
        {
            get { return data.pay_to_recd_from; }
            set { data.pay_to_recd_from = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        public string payment_order
        {
            get { return data.payment_order; }
            set { data.payment_order = value; }
        }

        public Isopening is_opening
        {
            get { return parseEnum<Isopening>(data.is_opening); }
            set { data.is_opening = value.ToString(); }
        }

        public string stock_entry
        {
            get { return data.stock_entry; }
            set { data.stock_entry = value; }
        }

        public string auto_repeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string from_template
        {
            get { return data.from_template; }
            set { data.from_template = value; }
        }


    }

    //Enums go here
    public enum Vouchertype
    {
        [Description("Journal Entry")]
        JournalEntry,
        [Description("Inter Company Journal Entry")]
        InterCompanyJournalEntry,
        [Description("Bank Entry")]
        BankEntry,
        [Description("Cash Entry")]
        CashEntry,
        [Description("Credit Card Entry")]
        CreditCardEntry,
        [Description("Debit Note")]
        DebitNote,
        [Description("Credit Note")]
        CreditNote,
        [Description("Contra Entry")]
        ContraEntry,
        [Description("Excise Entry")]
        ExciseEntry,
        [Description("Write Off Entry")]
        WriteOffEntry,
        [Description("Opening Entry")]
        OpeningEntry,
        [Description("Depreciation Entry")]
        DepreciationEntry,
        [Description("Exchange Rate Revaluation")]
        ExchangeRateRevaluation,
    }

    public enum Writeoffbasedon
    {
        [Description("Accounts Receivable")]
        AccountsReceivable,
        [Description("Accounts Payable")]
        AccountsPayable,
    }

    public enum Isopening
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }


}