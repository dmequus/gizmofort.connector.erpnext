using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan
{
    public class ERPLoan : ERPNextObjectBase
    {
        public ERPLoan() : this(new ERPObject(DocType.Loan)) { }
        public ERPLoan(ERPObject obj) : base(obj) { }

        public static ERPLoan Create(Applicanttype applicanttype, string applicant, string loantype, string postingdate, string company, double rateofinterest, string modeofpayment, string paymentaccount, string loanaccount, string interestincomeaccount, string penaltyincomeaccount)

        {
            ERPLoan obj = new ERPLoan();
            obj.applicant_type = applicanttype;
            obj.applicant = applicant;
            obj.loan_type = loantype;
            obj.posting_date = postingdate;
            obj.company = company;
            obj.rate_of_interest = rateofinterest;
            obj.mode_of_payment = modeofpayment;
            obj.payment_account = paymentaccount;
            obj.loan_account = loanaccount;
            obj.interest_income_account = interestincomeaccount;
            obj.penalty_income_account = penaltyincomeaccount;
            return obj;
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

        public string loan_type
        {
            get { return data.loan_type; }
            set { data.loan_type = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public double rate_of_interest
        {
            get { return data.rate_of_interest; }
            set { data.rate_of_interest = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        public string payment_account
        {
            get { return data.payment_account; }
            set { data.payment_account = value; }
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

        public string penalty_income_account
        {
            get { return data.penalty_income_account; }
            set { data.penalty_income_account = value; }
        }

        public string applicant_name
        {
            get { return data.applicant_name; }
            set { data.applicant_name = value; }
        }

        public string loan_application
        {
            get { return data.loan_application; }
            set { data.loan_application = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public long repay_from_salary
        {
            get { return data.repay_from_salary; }
            set { data.repay_from_salary = value; }
        }

        public double loan_amount
        {
            get { return data.loan_amount; }
            set { data.loan_amount = value; }
        }

        public string disbursement_date
        {
            get { return data.disbursement_date; }
            set { data.disbursement_date = value; }
        }

        public string repayment_start_date
        {
            get { return data.repayment_start_date; }
            set { data.repayment_start_date = value; }
        }

        public Repaymentmethod repayment_method
        {
            get { return parseEnum<Repaymentmethod>(data.repayment_method); }
            set { data.repayment_method = value.ToString(); }
        }

        public int repayment_periods
        {
            get { return data.repayment_periods; }
            set { data.repayment_periods = value; }
        }

        public double monthly_repayment_amount
        {
            get { return data.monthly_repayment_amount; }
            set { data.monthly_repayment_amount = value; }
        }

        public string repayment_schedule
        {
            get { return data.repayment_schedule; }
            set { data.repayment_schedule = value; }
        }

        public double total_payment
        {
            get { return data.total_payment; }
            set { data.total_payment = value; }
        }

        public double total_interest_payable
        {
            get { return data.total_interest_payable; }
            set { data.total_interest_payable = value; }
        }

        public double total_amount_paid
        {
            get { return data.total_amount_paid; }
            set { data.total_amount_paid = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public long is_secured_loan
        {
            get { return data.is_secured_loan; }
            set { data.is_secured_loan = value; }
        }

        public long is_term_loan
        {
            get { return data.is_term_loan; }
            set { data.is_term_loan = value; }
        }

        public double total_principal_paid
        {
            get { return data.total_principal_paid; }
            set { data.total_principal_paid = value; }
        }

        public string loan_security_pledge
        {
            get { return data.loan_security_pledge; }
            set { data.loan_security_pledge = value; }
        }

        public double disbursed_amount
        {
            get { return data.disbursed_amount; }
            set { data.disbursed_amount = value; }
        }

        public double maximum_loan_value
        {
            get { return data.maximum_loan_value; }
            set { data.maximum_loan_value = value; }
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

    public enum Status
    {
        [Description("Sanctioned")]
        Sanctioned,
        [Description("Partially Disbursed")]
        PartiallyDisbursed,
        [Description("Disbursed")]
        Disbursed,
        [Description("Loan Closure Requested")]
        LoanClosureRequested,
        [Description("Closed")]
        Closed,
    }

    public enum Repaymentmethod
    {
        [Description("Repay Fixed Amount per Period")]
        RepayFixedAmountperPeriod,
        [Description("Repay Over Number of Periods")]
        RepayOverNumberofPeriods,
    }


}