using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sanctioned_loan_amount
{
    public class ERPSanctioned_loan_amount : ERPNextObjectBase
    {
        public ERPSanctioned_loan_amount() : this(new ERPObject(DocType.Sanctioned_loan_amount)) { }
        public ERPSanctioned_loan_amount(ERPObject obj) : base(obj) { }

        public static ERPSanctioned_loan_amount Create(Applicanttype applicanttype, string applicant, string company, double sanctionedamountlimit)

        {
            ERPSanctioned_loan_amount obj = new ERPSanctioned_loan_amount();
            obj.applicant_type = applicanttype;
            obj.applicant = applicant;
            obj.company = company;
            obj.sanctioned_amount_limit = sanctionedamountlimit;
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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private double _sanctioned_amount_limit = 0.0;
        public double sanctioned_amount_limit
        {
            get { return data._sanctioned_amount_limit; }
            set { data._sanctioned_amount_limit = value; }
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