using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_unpledge
{
    public class ERPLoan_security_unpledge : ERPNextObjectBase
    {
        public ERPLoan_security_unpledge() : this(new ERPObject(DocType.Loan_security_unpledge)) { }
        public ERPLoan_security_unpledge(ERPObject obj) : base(obj) { }

        public static ERPLoan_security_unpledge Create(string applicant, string loan, string securities, string company, Applicanttype applicanttype)

        {
            ERPLoan_security_unpledge obj = new ERPLoan_security_unpledge();
            obj.applicant = applicant;
            obj.loan = loan;
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

        public string loan
        {
            get { return data.loan; }
            set { data.loan = value; }
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

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string unpledge_time
        {
            get { return data.unpledge_time; }
            set { data.unpledge_time = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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
        [Description("Approved")]
        Approved,
    }


}