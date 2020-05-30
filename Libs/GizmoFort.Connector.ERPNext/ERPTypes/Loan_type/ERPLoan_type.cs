using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_type
{
    public class ERPLoan_type : ERPNextObjectBase
    {
        public ERPLoan_type() : this(new ERPObject(DocType.Loan_type)) { }
        public ERPLoan_type(ERPObject obj) : base(obj) { }

        public static ERPLoan_type Create(string loanname, double rateofinterest, string modeofpayment, string paymentaccount, string loanaccount, string interestincomeaccount, string penaltyincomeaccount, string company)

        {
            ERPLoan_type obj = new ERPLoan_type();
            obj.loan_name = loanname;
            obj.rate_of_interest = rateofinterest;
            obj.mode_of_payment = modeofpayment;
            obj.payment_account = paymentaccount;
            obj.loan_account = loanaccount;
            obj.interest_income_account = interestincomeaccount;
            obj.penalty_income_account = penaltyincomeaccount;
            obj.company = company;
            return obj;
        }

        public string loan_name
        {
            get { return data.loan_name; }
            set
            {
                data.loan_name = value;
                data.name = value;
            }

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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private double _maximum_loan_amount = 0.0;
        public double maximum_loan_amount
        {
            get { return data._maximum_loan_amount; }
            set { data._maximum_loan_amount = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private int _is_term_loan = 0;
        public int is_term_loan
        {
            get { return data._is_term_loan; }
            set { data._is_term_loan = value; }
        }

        private double _penalty_interest_rate = 0.0;
        public double penalty_interest_rate
        {
            get { return data._penalty_interest_rate; }
            set { data._penalty_interest_rate = value; }
        }

        private int _grace_period_in_days = 0;
        public int grace_period_in_days
        {
            get { return data._grace_period_in_days; }
            set { data._grace_period_in_days = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}