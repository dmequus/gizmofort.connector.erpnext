using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Issue
{
    public class ERPIssue : ERPNextObjectBase
    {
        public ERPIssue() : this(new ERPObject(DocType.Issue)) { }
        public ERPIssue(ERPObject obj) : base(obj) { }

        public static ERPIssue Create(string subject)

        {
            ERPIssue obj = new ERPIssue();
            obj.subject = subject;
            return obj;
        }

        public string subject
        {
            get { return data.subject; }
            set
            {
                data.subject = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string raised_by
        {
            get { return data.raised_by; }
            set { data.raised_by = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string priority
        {
            get { return data.priority; }
            set { data.priority = value; }
        }

        public string issue_type
        {
            get { return data.issue_type; }
            set { data.issue_type = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string service_level_agreement
        {
            get { return data.service_level_agreement; }
            set { data.service_level_agreement = value; }
        }

        public string response_by
        {
            get { return data.response_by; }
            set { data.response_by = value; }
        }

        public string resolution_by
        {
            get { return data.resolution_by; }
            set { data.resolution_by = value; }
        }

        public double mins_to_first_response
        {
            get { return data.mins_to_first_response; }
            set { data.mins_to_first_response = value; }
        }

        public string first_responded_on
        {
            get { return data.first_responded_on; }
            set { data.first_responded_on = value; }
        }

        public string lead
        {
            get { return data.lead; }
            set { data.lead = value; }
        }

        public string contact
        {
            get { return data.contact; }
            set { data.contact = value; }
        }

        public string email_account
        {
            get { return data.email_account; }
            set { data.email_account = value; }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string resolution_details
        {
            get { return data.resolution_details; }
            set { data.resolution_details = value; }
        }

        public string opening_date
        {
            get { return data.opening_date; }
            set { data.opening_date = value; }
        }

        public string opening_time
        {
            get { return data.opening_time; }
            set { data.opening_time = value; }
        }

        public string resolution_date
        {
            get { return data.resolution_date; }
            set { data.resolution_date = value; }
        }

        public string content_type
        {
            get { return data.content_type; }
            set { data.content_type = value; }
        }

        public string attachment
        {
            get { return data.attachment; }
            set { data.attachment = value; }
        }

        public long via_customer_portal
        {
            get { return data.via_customer_portal; }
            set { data.via_customer_portal = value; }
        }

        public Agreementfulfilled agreement_fulfilled
        {
            get { return parseEnum<Agreementfulfilled>(data.agreement_fulfilled); }
            set { data.agreement_fulfilled = value.ToString(); }
        }

        public double response_by_variance
        {
            get { return data.response_by_variance; }
            set { data.response_by_variance = value; }
        }

        public double resolution_by_variance
        {
            get { return data.resolution_by_variance; }
            set { data.resolution_by_variance = value; }
        }

        public string service_level_agreement_creation
        {
            get { return data.service_level_agreement_creation; }
            set { data.service_level_agreement_creation = value; }
        }

        public string issue_split_from
        {
            get { return data.issue_split_from; }
            set { data.issue_split_from = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Replied")]
        Replied,
        [Description("Hold")]
        Hold,
        [Description("Closed")]
        Closed,
    }

    public enum Agreementfulfilled
    {
        [Description("Ongoing")]
        Ongoing,
        [Description("Fulfilled")]
        Fulfilled,
        [Description("Failed")]
        Failed,
    }


}