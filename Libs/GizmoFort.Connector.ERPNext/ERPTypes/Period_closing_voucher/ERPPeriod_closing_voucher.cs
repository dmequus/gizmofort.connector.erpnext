using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Period_closing_voucher
{
    public class ERPPeriod_closing_voucher : ERPNextObjectBase
    {
        public ERPPeriod_closing_voucher() : this(new ERPObject(DocType.Period_closing_voucher)) { }
        public ERPPeriod_closing_voucher(ERPObject obj) : base(obj) { }

        public static ERPPeriod_closing_voucher Create(string closingaccounthead, string transactiondate, string postingdate, string fiscalyear, string amendedfrom, string company, string remarks)

        {
            ERPPeriod_closing_voucher obj = new ERPPeriod_closing_voucher();
            obj.closing_account_head = closingaccounthead;
            obj.transaction_date = transactiondate;
            obj.posting_date = postingdate;
            obj.fiscal_year = fiscalyear;
            obj.amended_from = amendedfrom;
            obj.company = company;
            obj.remarks = remarks;
            return obj;
        }

        public string closing_account_head
        {
            get { return data.closing_account_head; }
            set
            {
                data.closing_account_head = value;
                data.name = value;
            }

        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string fiscal_year
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }


    }

    //Enums go here

}