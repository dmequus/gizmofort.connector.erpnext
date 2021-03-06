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

        public double payment_amount
        {
            get { return data.payment_amount; }
            set { data.payment_amount = value; }
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

        public double invoice_portion
        {
            get { return data.invoice_portion; }
            set { data.invoice_portion = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        public double paid_amount
        {
            get { return data.paid_amount; }
            set { data.paid_amount = value; }
        }


    }

    //Enums go here

}