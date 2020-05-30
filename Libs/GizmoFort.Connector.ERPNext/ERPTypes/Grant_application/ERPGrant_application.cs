using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Grant_application
{
    public class ERPGrant_application : ERPNextObjectBase
    {
        public ERPGrant_application() : this(new ERPObject(DocType.Grant_application)) { }
        public ERPGrant_application(ERPObject obj) : base(obj) { }

        public static ERPGrant_application Create(string applicantname, Applicanttype applicanttype, string contactperson, string email, Status status, string websiteurl, string company, string addresshtml, string contacthtml, string grantdescription, double amount, int hasanypastgrantrecord, string route, int published, double assessmentmark, string note, string assessmentmanager, int emailnotificationsent)

        {
            ERPGrant_application obj = new ERPGrant_application();
            obj.applicant_name = applicantname;
            obj.applicant_type = applicanttype;
            obj.contact_person = contactperson;
            obj.email = email;
            obj.status = status;
            obj.website_url = websiteurl;
            obj.company = company;
            obj.address_html = addresshtml;
            obj.contact_html = contacthtml;
            obj.grant_description = grantdescription;
            obj.amount = amount;
            obj.has_any_past_grant_record = hasanypastgrantrecord;
            obj.route = route;
            obj.published = published;
            obj.assessment_mark = assessmentmark;
            obj.note = note;
            obj.assessment_manager = assessmentmanager;
            obj.email_notification_sent = emailnotificationsent;
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

        public Applicanttype applicant_type
        {
            get { return parseEnum<Applicanttype>(data.applicant_type); }
            set { data.applicant_type = value.ToString(); }
        }

        public string contact_person
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string website_url
        {
            get { return data.website_url; }
            set { data.website_url = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }

        public string grant_description
        {
            get { return data.grant_description; }
            set { data.grant_description = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        private int _has_any_past_grant_record = 0;
        public int has_any_past_grant_record
        {
            get { return data._has_any_past_grant_record; }
            set { data._has_any_past_grant_record = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        private int _published = 0;
        public int published
        {
            get { return data._published; }
            set { data._published = value; }
        }

        private double _assessment_mark = 0.0;
        public double assessment_mark
        {
            get { return data._assessment_mark; }
            set { data._assessment_mark = value; }
        }

        public string note
        {
            get { return data.note; }
            set { data.note = value; }
        }

        public string assessment_manager
        {
            get { return data.assessment_manager; }
            set { data.assessment_manager = value; }
        }

        private int _email_notification_sent = 0;
        public int email_notification_sent
        {
            get { return data._email_notification_sent; }
            set { data._email_notification_sent = value; }
        }


    }

    //Enums go here
    public enum Applicanttype
    {
        [Description("Individual")]
        Individual,
        [Description("Organization")]
        Organization,
    }

    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Received")]
        Received,
        [Description("In Progress")]
        InProgress,
        [Description("Approved")]
        Approved,
        [Description("Rejected")]
        Rejected,
        [Description("Expired")]
        Expired,
        [Description("Withdrawn")]
        Withdrawn,
    }


}