using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Repayment_schedule
{
    public class ERPRepayment_schedule : ERPNextObjectBase
    {
        public ERPRepayment_schedule() : this(new ERPObject(DocType.Repayment_schedule)) { }
        public ERPRepayment_schedule(ERPObject obj) : base(obj) { }

        public static ERPRepayment_schedule Create()

        {
            ERPRepayment_schedule obj = new ERPRepayment_schedule();
            return obj;
        }

        public string payment_date
        {
            get { return data.payment_date; }
            set
            {
                data.payment_date = value;
                data.name = value;
            }

        }

        private double _principal_amount = 0.0;
        public double principal_amount
        {
            get { return data._principal_amount; }
            set { data._principal_amount = value; }
        }

        private double _interest_amount = 0.0;
        public double interest_amount
        {
            get { return data._interest_amount; }
            set { data._interest_amount = value; }
        }

        private double _total_payment = 0.0;
        public double total_payment
        {
            get { return data._total_payment; }
            set { data._total_payment = value; }
        }

        private double _balance_loan_amount = 0.0;
        public double balance_loan_amount
        {
            get { return data._balance_loan_amount; }
            set { data._balance_loan_amount = value; }
        }

        private int _is_accrued = 0;
        public int is_accrued
        {
            get { return data._is_accrued; }
            set { data._is_accrued = value; }
        }


    }

    //Enums go here

}