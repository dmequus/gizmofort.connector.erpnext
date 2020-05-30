using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_clearance
{
    public class ERPBank_clearance : ERPNextObjectBase
    {
        public ERPBank_clearance() : this(new ERPObject(DocType.Bank_clearance)) { }
        public ERPBank_clearance(ERPObject obj) : base(obj) { }

        public static ERPBank_clearance Create(string account, string fromdate, string todate)

        {
            ERPBank_clearance obj = new ERPBank_clearance();
            obj.account = account;
            obj.from_date = fromdate;
            obj.to_date = todate;
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

        public string account_currency
        {
            get { return data.account_currency; }
            set { data.account_currency = value; }
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }

        public long include_reconciled_entries
        {
            get { return data.include_reconciled_entries; }
            set { data.include_reconciled_entries = value; }
        }

        public long include_pos_transactions
        {
            get { return data.include_pos_transactions; }
            set { data.include_pos_transactions = value; }
        }

        public string payment_entries
        {
            get { return data.payment_entries; }
            set { data.payment_entries = value; }
        }

        public double total_amount
        {
            get { return data.total_amount; }
            set { data.total_amount = value; }
        }


    }

    //Enums go here

}