using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_interest_accrual
{
    public class ERPLoan_interest_accrual : ERPNextObjectBase
    {
        public ERPLoan_interest_accrual() : this(new ERPObject(DocType.Loan_interest_accrual)) { }
        public ERPLoan_interest_accrual(ERPObject obj) : base(obj) { }

        public static ERPLoan_interest_accrual Create()

        {
            ERPLoan_interest_accrual obj = new ERPLoan_interest_accrual();
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

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public double pending_principal_amount
        {
            get { return data.pending_principal_amount; }
            set { data.pending_principal_amount = value; }
        }

        public double interest_amount
        {
            get { return data.interest_amount; }
            set { data.interest_amount = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public Applicanttype applicant_type
        {
            get { return parseEnum<Applicanttype>(data.applicant_type); }
            set { data.applicant_type = value.ToString(); }
        }

        public string applicant
        {
            get { return data.applicant; }
            set { data.applicant = value; }
        }

        public string interest_income_account
        {
            get { return data.interest_income_account; }
            set { data.interest_income_account = value; }
        }

        public string loan_account
        {
            get { return data.loan_account; }
            set { data.loan_account = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public long is_term_loan
        {
            get { return data.is_term_loan; }
            set { data.is_term_loan = value; }
        }

        public double payable_principal_amount
        {
            get { return data.payable_principal_amount; }
            set { data.payable_principal_amount = value; }
        }

        public string process_loan_interest_accrual
        {
            get { return data.process_loan_interest_accrual; }
            set { data.process_loan_interest_accrual = value; }
        }

        public string repayment_schedule_name
        {
            get { return data.repayment_schedule_name; }
            set { data.repayment_schedule_name = value; }
        }

        public double paid_principal_amount
        {
            get { return data.paid_principal_amount; }
            set { data.paid_principal_amount = value; }
        }

        public double paid_interest_amount
        {
            get { return data.paid_interest_amount; }
            set { data.paid_interest_amount = value; }
        }


    }

    //Enums go here
    public enum Applicanttype
    {
        [Description("Employee")]
        Employee,
        [Description("Member")]
        Member,
        [Description("Customer")]
        Customer,
    }


}