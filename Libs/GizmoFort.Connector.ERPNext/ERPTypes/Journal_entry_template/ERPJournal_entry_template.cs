using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry_template
{
    public class ERPJournal_entry_template : ERPNextObjectBase
    {
        public ERPJournal_entry_template() : this(new ERPObject(DocType.Journal_entry_template)) { }
        public ERPJournal_entry_template(ERPObject obj) : base(obj) { }

        public static ERPJournal_entry_template Create(string templatetitle, Vouchertype vouchertype, string company, string namingseries)

        {
            ERPJournal_entry_template obj = new ERPJournal_entry_template();
            obj.template_title = templatetitle;
            obj.voucher_type = vouchertype;
            obj.company = company;
            obj.naming_series = namingseries;
            return obj;
        }

        public string template_title
        {
            get { return data.template_title; }
            set
            {
                data.template_title = value;
                data.name = value;
            }

        }

        public Vouchertype voucher_type
        {
            get { return parseEnum<Vouchertype>(data.voucher_type); }
            set { data.voucher_type = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public Isopening is_opening
        {
            get { return parseEnum<Isopening>(data.is_opening); }
            set { data.is_opening = value.ToString(); }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public long multi_currency
        {
            get { return data.multi_currency; }
            set { data.multi_currency = value; }
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

    public enum Isopening
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }


}