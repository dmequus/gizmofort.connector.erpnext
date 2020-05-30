using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_reconciliation_payment
{
    public class ERPPayment_reconciliation_payment : ERPNextObjectBase
    {
        public ERPPayment_reconciliation_payment() : this(new ERPObject(DocType.Payment_reconciliation_payment)) { }
        public ERPPayment_reconciliation_payment(ERPObject obj) : base(obj) { }

        public static ERPPayment_reconciliation_payment Create(string invoicenumber, double allocatedamount)

        {
            ERPPayment_reconciliation_payment obj = new ERPPayment_reconciliation_payment();
            obj.invoice_number = invoicenumber;
            obj.allocated_amount = allocatedamount;
            return obj;
        }

        public string invoice_number
        {
            get { return data.invoice_number; }
            set
            {
                data.invoice_number = value;
                data.name = value;
            }

        }

        private double _allocated_amount = 0.0;
        public double allocated_amount
        {
            get { return data._allocated_amount; }
            set { data._allocated_amount = value; }
        }

        public string reference_type
        {
            get { return data.reference_type; }
            set { data.reference_type = value; }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string is_advance
        {
            get { return data.is_advance; }
            set { data.is_advance = value; }
        }

        public string reference_row
        {
            get { return data.reference_row; }
            set { data.reference_row = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public string remark
        {
            get { return data.remark; }
            set { data.remark = value; }
        }

        public string difference_account
        {
            get { return data.difference_account; }
            set { data.difference_account = value; }
        }

        private double _difference_amount = 0.0;
        public double difference_amount
        {
            get { return data._difference_amount; }
            set { data._difference_amount = value; }
        }


    }

    //Enums go here

}