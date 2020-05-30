using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_slip_loan
{
    public class ERPSalary_slip_loan : ERPNextObjectBase
    {
        public ERPSalary_slip_loan() : this(new ERPObject(DocType.Salary_slip_loan)) { }
        public ERPSalary_slip_loan(ERPObject obj) : base(obj) { }

        public static ERPSalary_slip_loan Create(string loan)

        {
            ERPSalary_slip_loan obj = new ERPSalary_slip_loan();
            obj.loan = loan;
            return obj;
        }

        public string loan
        {
            get { return data.loan; }
            set
            {
                data.loan = value;
                data.name = value;
            }

        }

        public string loan_account
        {
            get { return data.loan_account; }
            set { data.loan_account = value; }
        }

        public string interest_income_account
        {
            get { return data.interest_income_account; }
            set { data.interest_income_account = value; }
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

        public string loan_repayment_entry
        {
            get { return data.loan_repayment_entry; }
            set { data.loan_repayment_entry = value; }
        }

        public string loan_type
        {
            get { return data.loan_type; }
            set { data.loan_type = value; }
        }


    }

    //Enums go here

}