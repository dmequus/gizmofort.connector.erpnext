using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_settings
{
    public class ERPBank_statement_transaction_settings : ERPNextObjectBase
    {
        public ERPBank_statement_transaction_settings() : this(new ERPObject(DocType.Bank_statement_transaction_settings)) { }
        public ERPBank_statement_transaction_settings(ERPObject obj) : base(obj) { }

        public static ERPBank_statement_transaction_settings Create(string bankaccount, string dateformat, string headeritems, string mappeditems)

        {
            ERPBank_statement_transaction_settings obj = new ERPBank_statement_transaction_settings();
            obj.bank_account = bankaccount;
            obj.date_format = dateformat;
            obj.header_items = headeritems;
            obj.mapped_items = mappeditems;
            return obj;
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set
            {
                data.bank_account = value;
                data.name = value;
            }

        }

        public string date_format
        {
            get { return data.date_format; }
            set { data.date_format = value; }
        }

        public string header_items
        {
            get { return data.header_items; }
            set { data.header_items = value; }
        }

        public string mapped_items
        {
            get { return data.mapped_items; }
            set { data.mapped_items = value; }
        }


    }

    //Enums go here

}