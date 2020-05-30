using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_repayment
{
    public class ERPLoan_repayment : ERPNextObjectBase
    {
        public ERPLoan_repayment() : this(new ERPObject(DocType.Loan_repayment)) { }
        public ERPLoan_repayment(ERPObject obj) : base(obj) { }

        public static ERPLoan_repayment Create(string againstloan, string postingdate, string applicant, Paymenttype paymenttype, double amountpaid)

        {
            ERPLoan_repayment obj = new ERPLoan_repayment();
            obj.against_loan = againstloan;
            obj.posting_date = postingdate;
            obj.applicant = applicant;
            obj.payment_type = paymenttype;
            obj.amount_paid = amountpaid;
            return obj;
        }

        public string against_loan
        {
            get { return data.against_loan; }
            set
            {
                data.against_loan = value;
                data.name = value;
            }

        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string applicant
        {
            get { return data.applicant; }
            set { data.applicant = value; }
        }

        public Paymenttype payment_type
        {
            get { return parseEnum<Paymenttype>(data.payment_type); }
            set { data.payment_type = value.ToString(); }
        }

        public double amount_paid
        {
            get { return data.amount_paid; }
            set { data.amount_paid = value; }
        }

        public double penalty_amount
        {
            get { return data.penalty_amount; }
            set { data.penalty_amount = value; }
        }

        public double interest_payable
        {
            get { return data.interest_payable; }
            set { data.interest_payable = value; }
        }

        public string loan_type
        {
            get { return data.loan_type; }
            set { data.loan_type = value; }
        }

        public double payable_amount
        {
            get { return data.payable_amount; }
            set { data.payable_amount = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public double pending_principal_amount
        {
            get { return data.pending_principal_amount; }
            set { data.pending_principal_amount = value; }
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

        public string reference_number
        {
            get { return data.reference_number; }
            set { data.reference_number = value; }
        }

        public string reference_date
        {
            get { return data.reference_date; }
            set { data.reference_date = value; }
        }

        public double principal_amount_paid
        {
            get { return data.principal_amount_paid; }
            set { data.principal_amount_paid = value; }
        }

        public Applicanttype applicant_type
        {
            get { return parseEnum<Applicanttype>(data.applicant_type); }
            set { data.applicant_type = value.ToString(); }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        public string repayment_details
        {
            get { return data.repayment_details; }
            set { data.repayment_details = value; }
        }


    }

    //Enums go here
    public enum Paymenttype
    {
        [Description("Regular Payment")]
        RegularPayment,
        [Description("Loan Closure")]
        LoanClosure,
    }

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