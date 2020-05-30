using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_application
{
    public class ERPLoan_application : ERPNextObjectBase
    {
        public ERPLoan_application() : this(new ERPObject(DocType.Loan_application)) { }
        public ERPLoan_application(ERPObject obj) : base(obj) { }

        public static ERPLoan_application Create(string applicant, Applicanttype applicanttype, string company, string loantype)

        {
            ERPLoan_application obj = new ERPLoan_application();
            obj.applicant = applicant;
            obj.applicant_type = applicanttype;
            obj.company = company;
            obj.loan_type = loantype;
            return obj;
        }

        public string applicant
        {
            get { return data.applicant; }
            set
            {
                data.applicant = value;
                data.name = value;
            }

        }

        public Applicanttype applicant_type
        {
            get { return parseEnum<Applicanttype>(data.applicant_type); }
            set { data.applicant_type = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string loan_type
        {
            get { return data.loan_type; }
            set { data.loan_type = value; }
        }

        public string applicant_name
        {
            get { return data.applicant_name; }
            set { data.applicant_name = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public double loan_amount
        {
            get { return data.loan_amount; }
            set { data.loan_amount = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public Repaymentmethod repayment_method
        {
            get { return parseEnum<Repaymentmethod>(data.repayment_method); }
            set { data.repayment_method = value.ToString(); }
        }

        public double rate_of_interest
        {
            get { return data.rate_of_interest; }
            set { data.rate_of_interest = value; }
        }

        public double total_payable_interest
        {
            get { return data.total_payable_interest; }
            set { data.total_payable_interest = value; }
        }

        public double repayment_amount
        {
            get { return data.repayment_amount; }
            set { data.repayment_amount = value; }
        }

        public int repayment_periods
        {
            get { return data.repayment_periods; }
            set { data.repayment_periods = value; }
        }

        public double total_payable_amount
        {
            get { return data.total_payable_amount; }
            set { data.total_payable_amount = value; }
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

        public string proposed_pledges
        {
            get { return data.proposed_pledges; }
            set { data.proposed_pledges = value; }
        }

        public double maximum_loan_amount
        {
            get { return data.maximum_loan_amount; }
            set { data.maximum_loan_amount = value; }
        }

        public long is_term_loan
        {
            get { return data.is_term_loan; }
            set { data.is_term_loan = value; }
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
        [Description("Open")]
        Open,
        [Description("Approved")]
        Approved,
        [Description("Rejected")]
        Rejected,
    }

    public enum Repaymentmethod
    {
        [Description("Repay Fixed Amount per Period")]
        RepayFixedAmountperPeriod,
        [Description("Repay Over Number of Periods")]
        RepayOverNumberofPeriods,
    }


}