using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Email_campaign
{
    public class ERPEmail_campaign : ERPNextObjectBase
    {
        public ERPEmail_campaign() : this(new ERPObject(DocType.Email_campaign)) { }
        public ERPEmail_campaign(ERPObject obj) : base(obj) { }

        public static ERPEmail_campaign Create(string campaignname, string startdate, Emailcampaignfor emailcampaignfor, string recipient)

        {
            ERPEmail_campaign obj = new ERPEmail_campaign();
            obj.campaign_name = campaignname;
            obj.start_date = startdate;
            obj.email_campaign_for = emailcampaignfor;
            obj.recipient = recipient;
            return obj;
        }

        public string campaign_name
        {
            get { return data.campaign_name; }
            set
            {
                data.campaign_name = value;
                data.name = value;
            }

        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public Emailcampaignfor email_campaign_for
        {
            get { return parseEnum<Emailcampaignfor>(data.email_campaign_for); }
            set { data.email_campaign_for = value.ToString(); }
        }

        public string recipient
        {
            get { return data.recipient; }
            set { data.recipient = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public string sender
        {
            get { return data.sender; }
            set { data.sender = value; }
        }


    }

    //Enums go here
    public enum Emailcampaignfor
    {
        [Description("Lead")]
        Lead,
        [Description("Contact")]
        Contact,
    }

    public enum Status
    {
        [Description("Scheduled")]
        Scheduled,
        [Description("In Progress")]
        InProgress,
        [Description("Completed")]
        Completed,
        [Description("Unsubscribed")]
        Unsubscribed,
    }


}