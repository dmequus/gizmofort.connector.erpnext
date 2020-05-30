using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_offer
{
    public class ERPJob_offer : ERPNextObjectBase
    {
        public ERPJob_offer() : this(new ERPObject(DocType.Job_offer)) { }
        public ERPJob_offer(ERPObject obj) : base(obj) { }

        public static ERPJob_offer Create(string applicantname, string jobapplicant, string offerdate, string designation, string company)

        {
            ERPJob_offer obj = new ERPJob_offer();
            obj.applicant_name = applicantname;
            obj.job_applicant = jobapplicant;
            obj.offer_date = offerdate;
            obj.designation = designation;
            obj.company = company;
            return obj;
        }

        public string applicant_name
        {
            get { return data.applicant_name; }
            set
            {
                data.applicant_name = value;
                data.name = value;
            }

        }

        public string job_applicant
        {
            get { return data.job_applicant; }
            set { data.job_applicant = value; }
        }

        public string offer_date
        {
            get { return data.offer_date; }
            set { data.offer_date = value; }
        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string applicant_email
        {
            get { return data.applicant_email; }
            set { data.applicant_email = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string offer_terms
        {
            get { return data.offer_terms; }
            set { data.offer_terms = value; }
        }

        public string select_terms
        {
            get { return data.select_terms; }
            set { data.select_terms = value; }
        }

        public string terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Awaiting Response")]
        AwaitingResponse,
        [Description("Accepted")]
        Accepted,
        [Description("Rejected")]
        Rejected,
    }


}