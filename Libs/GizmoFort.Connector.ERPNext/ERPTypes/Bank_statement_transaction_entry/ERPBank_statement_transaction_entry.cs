using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_entry
{
    public class ERPBank_statement_transaction_entry : ERPNextObjectBase
    {
        public ERPBank_statement_transaction_entry() : this(new ERPObject(DocType.Bank_statement_transaction_entry)) { }
        public ERPBank_statement_transaction_entry(ERPObject obj) : base(obj) { }

        public static ERPBank_statement_transaction_entry Create(string bankaccount, string fromdate, string todate, string banksettings, string bank, string receivableaccount, string payableaccount, string bankstatement, string newtransactionitems, string paymentinvoiceitems, string reconciledtransactionitems, string amendedfrom)

        {
            ERPBank_statement_transaction_entry obj = new ERPBank_statement_transaction_entry();
            obj.bank_account = bankaccount;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.bank_settings = banksettings;
            obj.bank = bank;
            obj.receivable_account = receivableaccount;
            obj.payable_account = payableaccount;
            obj.bank_statement = bankstatement;
            obj.new_transaction_items = newtransactionitems;
            obj.payment_invoice_items = paymentinvoiceitems;
            obj.reconciled_transaction_items = reconciledtransactionitems;
            obj.amended_from = amendedfrom;
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

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public string bank_settings
        {
            get { return data.bank_settings; }
            set { data.bank_settings = value; }
        }

        public string bank
        {
            get { return data.bank; }
            set { data.bank = value; }
        }

        public string receivable_account
        {
            get { return data.receivable_account; }
            set { data.receivable_account = value; }
        }

        public string payable_account
        {
            get { return data.payable_account; }
            set { data.payable_account = value; }
        }

        public string bank_statement
        {
            get { return data.bank_statement; }
            set { data.bank_statement = value; }
        }

        public string new_transaction_items
        {
            get { return data.new_transaction_items; }
            set { data.new_transaction_items = value; }
        }

        public string payment_invoice_items
        {
            get { return data.payment_invoice_items; }
            set { data.payment_invoice_items = value; }
        }

        public string reconciled_transaction_items
        {
            get { return data.reconciled_transaction_items; }
            set { data.reconciled_transaction_items = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}