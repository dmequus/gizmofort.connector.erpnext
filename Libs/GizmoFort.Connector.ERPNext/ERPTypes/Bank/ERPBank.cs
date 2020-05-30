using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank
{
    public class ERPBank : ERPNextObjectBase
    {
        public ERPBank() : this(new ERPObject(DocType.Bank)) { }
        public ERPBank(ERPObject obj) : base(obj) { }

        public static ERPBank Create(string bankname)

        {
            ERPBank obj = new ERPBank();
            obj.bank_name = bankname;
            return obj;
        }

        public string bank_name
        {
            get { return data.bank_name; }
            set
            {
                data.bank_name = value;
                data.name = value;
            }

        }

        public string swift_number
        {
            get { return data.swift_number; }
            set { data.swift_number = value; }
        }

        public string branch_code
        {
            get { return data.branch_code; }
            set { data.branch_code = value; }
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

        public string bank_transaction_mapping
        {
            get { return data.bank_transaction_mapping; }
            set { data.bank_transaction_mapping = value; }
        }

        public string plaid_access_token
        {
            get { return data.plaid_access_token; }
            set { data.plaid_access_token = value; }
        }


    }

    //Enums go here

}