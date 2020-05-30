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