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

        public double principal_amount
        {
            get { return data.principal_amount; }
            set { data.principal_amount = value; }
        }

        public double interest_amount
        {
            get { return data.interest_amount; }
            set { data.interest_amount = value; }
        }

        public double total_payment
        {
            get { return data.total_payment; }
            set { data.total_payment = value; }
        }

        public double balance_loan_amount
        {
            get { return data.balance_loan_amount; }
            set { data.balance_loan_amount = value; }
        }

        public long is_accrued
        {
            get { return data.is_accrued; }
            set { data.is_accrued = value; }
        }


    }

    //Enums go here

}