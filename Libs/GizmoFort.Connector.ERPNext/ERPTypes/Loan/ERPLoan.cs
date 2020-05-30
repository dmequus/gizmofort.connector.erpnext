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

        private double _rate_of_interest = 0.0;
        public double rate_of_interest
        {
            get { return data._rate_of_interest; }
            set { data._rate_of_interest = value; }
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

        private int _repay_from_salary = 0;
        public int repay_from_salary
        {
            get { return data._repay_from_salary; }
            set { data._repay_from_salary = value; }
        }

        private double _loan_amount = 0.0;
        public double loan_amount
        {
            get { return data._loan_amount; }
            set { data._loan_amount = value; }
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

        private int _repayment_periods = 0;
        public int repayment_periods
        {
            get { return data._repayment_periods; }
            set { data._repayment_periods = value; }
        }

        private double _monthly_repayment_amount = 0.0;
        public double monthly_repayment_amount
        {
            get { return data._monthly_repayment_amount; }
            set { data._monthly_repayment_amount = value; }
        }

        public string repayment_schedule
        {
            get { return data.repayment_schedule; }
            set { data.repayment_schedule = value; }
        }

        private double _total_payment = 0.0;
        public double total_payment
        {
            get { return data._total_payment; }
            set { data._total_payment = value; }
        }

        private double _total_interest_payable = 0.0;
        public double total_interest_payable
        {
            get { return data._total_interest_payable; }
            set { data._total_interest_payable = value; }
        }

        private double _total_amount_paid = 0.0;
        public double total_amount_paid
        {
            get { return data._total_amount_paid; }
            set { data._total_amount_paid = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        private int _is_secured_loan = 0;
        public int is_secured_loan
        {
            get { return data._is_secured_loan; }
            set { data._is_secured_loan = value; }
        }

        private int _is_term_loan = 0;
        public int is_term_loan
        {
            get { return data._is_term_loan; }
            set { data._is_term_loan = value; }
        }

        private double _total_principal_paid = 0.0;
        public double total_principal_paid
        {
            get { return data._total_principal_paid; }
            set { data._total_principal_paid = value; }
        }

        public string loan_security_pledge
        {
            get { return data.loan_security_pledge; }
            set { data.loan_security_pledge = value; }
        }

        private double _disbursed_amount = 0.0;
        public double disbursed_amount
        {
            get { return data._disbursed_amount; }
            set { data._disbursed_amount = value; }
        }

        private double _maximum_loan_value = 0.0;
        public double maximum_loan_value
        {
            get { return data._maximum_loan_value; }
            set { data._maximum_loan_value = value; }
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