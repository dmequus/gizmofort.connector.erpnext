using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_guarantee
{
    public class ERPBank_guarantee : ERPNextObjectBase
    {
        public ERPBank_guarantee() : this(new ERPObject(DocType.Bank_guarantee)) { }
        public ERPBank_guarantee(ERPObject obj) : base(obj) { }

        public static ERPBank_guarantee Create(string customer, Bgtype bgtype, string referencedoctype, string referencedocname, string supplier, string project, double amount, string startdate, int validity, string enddate, string bank, string bankaccount, string account, string bankaccountno, string iban, string branchcode, string swiftnumber, string moreinformation, string bankguaranteenumber, string nameofbeneficiary, double marginmoney, double charges, string fixeddepositnumber, string amendedfrom)

        {
            ERPBank_guarantee obj = new ERPBank_guarantee();
            obj.customer = customer;
            obj.bg_type = bgtype;
            obj.reference_doctype = referencedoctype;
            obj.reference_docname = referencedocname;
            obj.supplier = supplier;
            obj.project = project;
            obj.amount = amount;
            obj.start_date = startdate;
            obj.validity = validity;
            obj.end_date = enddate;
            obj.bank = bank;
            obj.bank_account = bankaccount;
            obj.account = account;
            obj.bank_account_no = bankaccountno;
            obj.iban = iban;
            obj.branch_code = branchcode;
            obj.swift_number = swiftnumber;
            obj.more_information = moreinformation;
            obj.bank_guarantee_number = bankguaranteenumber;
            obj.name_of_beneficiary = nameofbeneficiary;
            obj.margin_money = marginmoney;
            obj.charges = charges;
            obj.fixed_deposit_number = fixeddepositnumber;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string customer
        {
            get { return data.customer; }
            set
            {
                data.customer = value;
                data.name = value;
            }

        }

        public Bgtype bg_type
        {
            get { return parseEnum<Bgtype>(data.bg_type); }
            set { data.bg_type = value.ToString(); }
        }

        public string reference_doctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        public string reference_docname
        {
            get { return data.reference_docname; }
            set { data.reference_docname = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        private int _validity = 0;
        public int validity
        {
            get { return data._validity; }
            set { data._validity = value; }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public string bank
        {
            get { return data.bank; }
            set { data.bank = value; }
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        public string bank_account_no
        {
            get { return data.bank_account_no; }
            set { data.bank_account_no = value; }
        }

        public string iban
        {
            get { return data.iban; }
            set { data.iban = value; }
        }

        public string branch_code
        {
            get { return data.branch_code; }
            set { data.branch_code = value; }
        }

        public string swift_number
        {
            get { return data.swift_number; }
            set { data.swift_number = value; }
        }

        public string more_information
        {
            get { return data.more_information; }
            set { data.more_information = value; }
        }

        public string bank_guarantee_number
        {
            get { return data.bank_guarantee_number; }
            set { data.bank_guarantee_number = value; }
        }

        public string name_of_beneficiary
        {
            get { return data.name_of_beneficiary; }
            set { data.name_of_beneficiary = value; }
        }

        private double _margin_money = 0.0;
        public double margin_money
        {
            get { return data._margin_money; }
            set { data._margin_money = value; }
        }

        private double _charges = 0.0;
        public double charges
        {
            get { return data._charges; }
            set { data._charges = value; }
        }

        public string fixed_deposit_number
        {
            get { return data.fixed_deposit_number; }
            set { data.fixed_deposit_number = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Bgtype
    {
        [Description("Receiving")]
        Receiving,
        [Description("Providing")]
        Providing,
    }


}