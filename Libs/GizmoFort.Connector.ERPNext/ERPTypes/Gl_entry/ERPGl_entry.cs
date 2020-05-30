using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Gl_entry
{
    public class ERPGl_entry : ERPNextObjectBase
    {
        public ERPGl_entry() : this(new ERPObject(DocType.Gl_entry)) { }
        public ERPGl_entry(ERPObject obj) : base(obj) { }

        public static ERPGl_entry Create()

        {
            ERPGl_entry obj = new ERPGl_entry();
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

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
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

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        private double _debit = 0.0;
        public double debit
        {
            get { return data._debit; }
            set { data._debit = value; }
        }

        private double _credit = 0.0;
        public double credit
        {
            get { return data._credit; }
            set { data._credit = value; }
        }

        public string account_currency
        {
            get { return data.account_currency; }
            set { data.account_currency = value; }
        }

        private double _debit_in_account_currency = 0.0;
        public double debit_in_account_currency
        {
            get { return data._debit_in_account_currency; }
            set { data._debit_in_account_currency = value; }
        }

        private double _credit_in_account_currency = 0.0;
        public double credit_in_account_currency
        {
            get { return data._credit_in_account_currency; }
            set { data._credit_in_account_currency = value; }
        }

        public string against
        {
            get { return data.against; }
            set { data.against = value; }
        }

        public string against_voucher_type
        {
            get { return data.against_voucher_type; }
            set { data.against_voucher_type = value; }
        }

        public string against_voucher
        {
            get { return data.against_voucher; }
            set { data.against_voucher = value; }
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

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        public Isopening is_opening
        {
            get { return parseEnum<Isopening>(data.is_opening); }
            set { data.is_opening = value.ToString(); }
        }

        public Isadvance is_advance
        {
            get { return parseEnum<Isadvance>(data.is_advance); }
            set { data.is_advance = value.ToString(); }
        }

        public string fiscal_year
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string finance_book
        {
            get { return data.finance_book; }
            set { data.finance_book = value; }
        }

        private int _to_rename = 0;
        public int to_rename
        {
            get { return data._to_rename; }
            set { data._to_rename = value; }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        private int _is_cancelled = 0;
        public int is_cancelled
        {
            get { return data._is_cancelled; }
            set { data._is_cancelled = value; }
        }


    }

    //Enums go here
    public enum Isopening
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }

    public enum Isadvance
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }


}