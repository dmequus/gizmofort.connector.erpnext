using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_transaction_payments
{
    public class ERPBank_transaction_payments : ERPNextObjectBase
    {
        public ERPBank_transaction_payments() : this(new ERPObject(DocType.Bank_transaction_payments)) { }
        public ERPBank_transaction_payments(ERPObject obj) : base(obj) { }

        public static ERPBank_transaction_payments Create(string paymentdocument, string paymententry, double allocatedamount)

        {
            ERPBank_transaction_payments obj = new ERPBank_transaction_payments();
            obj.payment_document = paymentdocument;
            obj.payment_entry = paymententry;
            obj.allocated_amount = allocatedamount;
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

        private double _allocated_amount = 0.0;
        public double allocated_amount
        {
            get { return data._allocated_amount; }
            set { data._allocated_amount = value; }
        }

        public string clearance_date
        {
            get { return data.clearance_date; }
            set { data.clearance_date = value; }
        }


    }

    //Enums go here

}