using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_pledge
{
    public class ERPLoan_security_pledge : ERPNextObjectBase
    {
        public ERPLoan_security_pledge() : this(new ERPObject(DocType.Loan_security_pledge)) { }
        public ERPLoan_security_pledge(ERPObject obj) : base(obj) { }

        public static ERPLoan_security_pledge Create(string applicant, string securities, string company, Applicanttype applicanttype)

        {
            ERPLoan_security_pledge obj = new ERPLoan_security_pledge();
            obj.applicant = applicant;
            obj.securities = securities;
            obj.company = company;
            obj.applicant_type = applicanttype;
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

        public string securities
        {
            get { return data.securities; }
            set { data.securities = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public Applicanttype applicant_type
        {
            get { return parseEnum<Applicanttype>(data.applicant_type); }
            set { data.applicant_type = value.ToString(); }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string loan
        {
            get { return data.loan; }
            set { data.loan = value; }
        }

        public string loan_application
        {
            get { return data.loan_application; }
            set { data.loan_application = value; }
        }

        private double _total_security_value = 0.0;
        public double total_security_value
        {
            get { return data._total_security_value; }
            set { data._total_security_value = value; }
        }

        private double _maximum_loan_value = 0.0;
        public double maximum_loan_value
        {
            get { return data._maximum_loan_value; }
            set { data._maximum_loan_value = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string pledge_time
        {
            get { return data.pledge_time; }
            set { data.pledge_time = value; }
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
        [Description("Requested")]
        Requested,
        [Description("Unpledged")]
        Unpledged,
        [Description("Pledged")]
        Pledged,
        [Description("Partially Pledged")]
        PartiallyPledged,
    }


}