using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_repayment_detail
{
    public class ERPLoan_repayment_detail : ERPNextObjectBase
    {
        public ERPLoan_repayment_detail() : this(new ERPObject(DocType.Loan_repayment_detail)) { }
        public ERPLoan_repayment_detail(ERPObject obj) : base(obj) { }

        public static ERPLoan_repayment_detail Create()

        {
            ERPLoan_repayment_detail obj = new ERPLoan_repayment_detail();
            return obj;
        }

        public string loan_interest_accrual
        {
            get { return data.loan_interest_accrual; }
            set
            {
                data.loan_interest_accrual = value;
                data.name = value;
            }

        }

        private double _paid_principal_amount = 0.0;
        public double paid_principal_amount
        {
            get { return data._paid_principal_amount; }
            set { data._paid_principal_amount = value; }
        }

        private double _paid_interest_amount = 0.0;
        public double paid_interest_amount
        {
            get { return data._paid_interest_amount; }
            set { data._paid_interest_amount = value; }
        }


    }

    //Enums go here

}