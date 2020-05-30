using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_account
{
    public class ERPBank_account : ERPNextObjectBase
    {
        public ERPBank_account() : this(new ERPObject(DocType.Bank_account)) { }
        public ERPBank_account(ERPObject obj) : base(obj) { }

        public static ERPBank_account Create(string accountname, string bank)

        {
            ERPBank_account obj = new ERPBank_account();
            obj.account_name = accountname;
            obj.bank = bank;
            return obj;
        }

        public string account_name
        {
            get { return data.account_name; }
            set
            {
                data.account_name = value;
                data.name = value;
            }

        }

        public string bank
        {
            get { return data.bank; }
            set { data.bank = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        public string account_type
        {
            get { return data.account_type; }
            set { data.account_type = value; }
        }

        public string account_subtype
        {
            get { return data.account_subtype; }
            set { data.account_subtype = value; }
        }

        private int _is_default = 0;
        public int is_default
        {
            get { return data._is_default; }
            set { data._is_default = value; }
        }

        private int _is_company_account = 0;
        public int is_company_account
        {
            get { return data._is_company_account; }
            set { data._is_company_account = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
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

        public string iban
        {
            get { return data.iban; }
            set { data.iban = value; }
        }

        public string bank_account_no
        {
            get { return data.bank_account_no; }
            set { data.bank_account_no = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }

        public string integration_id
        {
            get { return data.integration_id; }
            set { data.integration_id = value; }
        }

        public string last_integration_date
        {
            get { return data.last_integration_date; }
            set { data.last_integration_date = value; }
        }

        public string mask
        {
            get { return data.mask; }
            set { data.mask = value; }
        }


    }

    //Enums go here

}