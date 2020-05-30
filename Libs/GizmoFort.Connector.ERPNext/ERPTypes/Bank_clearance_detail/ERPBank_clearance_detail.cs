using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_clearance_detail
{
    public class ERPBank_clearance_detail : ERPNextObjectBase
    {
        public ERPBank_clearance_detail() : this(new ERPObject(DocType.Bank_clearance_detail)) { }
        public ERPBank_clearance_detail(ERPObject obj) : base(obj) { }

        public static ERPBank_clearance_detail Create(string paymentdocument, string paymententry, string againstaccount, string amount, string postingdate, string chequenumber, string chequedate, string clearancedate)

        {
            ERPBank_clearance_detail obj = new ERPBank_clearance_detail();
            obj.payment_document = paymentdocument;
            obj.payment_entry = paymententry;
            obj.against_account = againstaccount;
            obj.amount = amount;
            obj.posting_date = postingdate;
            obj.cheque_number = chequenumber;
            obj.cheque_date = chequedate;
            obj.clearance_date = clearancedate;
            return obj;
        }

        public string payment_document
        {
            get { return data.payment_document; }
            set
            {
                data.payment_document = value;
                data.name = value;
            }

        }

        public string payment_entry
        {
            get { return data.payment_entry; }
            set { data.payment_entry = value; }
        }

        public string against_account
        {
            get { return data.against_account; }
            set { data.against_account = value; }
        }

        public string amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string cheque_number
        {
            get { return data.cheque_number; }
            set { data.cheque_number = value; }
        }

        public string cheque_date
        {
            get { return data.cheque_date; }
            set { data.cheque_date = value; }
        }

        public string clearance_date
        {
            get { return data.clearance_date; }
            set { data.clearance_date = value; }
        }


    }

    //Enums go here

}