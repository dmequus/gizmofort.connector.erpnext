using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_disbursement
{
    public class ERPLoan_disbursement : ERPNextObjectBase
    {
        public ERPLoan_disbursement() : this(new ERPObject(DocType.Loan_disbursement)) { }
        public ERPLoan_disbursement(ERPObject obj) : base(obj) { }

        public static ERPLoan_disbursement Create()

        {
            ERPLoan_disbursement obj = new ERPLoan_disbursement();
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

        public string disbursement_date
        {
            get { return data.disbursement_date; }
            set { data.disbursement_date = value; }
        }

        private double _disbursed_amount = 0.0;
        public double disbursed_amount
        {
            get { return data._disbursed_amount; }
            set { data._disbursed_amount = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string applicant
        {
            get { return data.applicant; }
            set { data.applicant = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public Applicanttype applicant_type
        {
            get { return parseEnum<Applicanttype>(data.applicant_type); }
            set { data.applicant_type = value.ToString(); }
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
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