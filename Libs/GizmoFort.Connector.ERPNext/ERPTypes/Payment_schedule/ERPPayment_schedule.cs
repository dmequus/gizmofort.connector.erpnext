using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_schedule
{
    public class ERPPayment_schedule : ERPNextObjectBase
    {
        public ERPPayment_schedule() : this(new ERPObject(DocType.Payment_schedule)) { }
        public ERPPayment_schedule(ERPObject obj) : base(obj) { }

        public static ERPPayment_schedule Create(string duedate, double paymentamount)

        {
            ERPPayment_schedule obj = new ERPPayment_schedule();
            obj.due_date = duedate;
            obj.payment_amount = paymentamount;
            return obj;
        }

        public string due_date
        {
            get { return data.due_date; }
            set
            {
                data.due_date = value;
                data.name = value;
            }

        }

        private double _payment_amount = 0.0;
        public double payment_amount
        {
            get { return data._payment_amount; }
            set { data._payment_amount = value; }
        }

        public string payment_term
        {
            get { return data.payment_term; }
            set { data.payment_term = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private double _invoice_portion = 0.0;
        public double invoice_portion
        {
            get { return data._invoice_portion; }
            set { data._invoice_portion = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        private double _paid_amount = 0.0;
        public double paid_amount
        {
            get { return data._paid_amount; }
            set { data._paid_amount = value; }
        }


    }

    //Enums go here

}