using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lead
{
    public class ERPLead : ERPNextObjectBase
    {
        public ERPLead() : this(new ERPObject(DocType.Lead)) { }
        public ERPLead(ERPObject obj) : base(obj) { }

        public static ERPLead Create(string title, Status status)

        {
            ERPLead obj = new ERPLead();
            obj.title = title;
            obj.status = status;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public long organization_lead
        {
            get { return data.organization_lead; }
            set { data.organization_lead = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string lead_name
        {
            get { return data.lead_name; }
            set { data.lead_name = value; }
        }

        public string company_name
        {
            get { return data.company_name; }
            set { data.company_name = value; }
        }

        public string email_id
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        public string lead_owner
        {
            get { return data.lead_owner; }
            set { data.lead_owner = value; }
        }

        public string salutation
        {
            get { return data.salutation; }
            set { data.salutation = value; }
        }

        public string gender
        {
            get { return data.gender; }
            set { data.gender = value; }
        }

        public string source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string campaign_name
        {
            get { return data.campaign_name; }
            set { data.campaign_name = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string contact_by
        {
            get { return data.contact_by; }
            set { data.contact_by = value; }
        }

        public string contact_date
        {
            get { return data.contact_date; }
            set { data.contact_date = value; }
        }

        public string ends_on
        {
            get { return data.ends_on; }
            set { data.ends_on = value; }
        }

        public string notes
        {
            get { return data.notes; }
            set { data.notes = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string address_title
        {
            get { return data.address_title; }
            set { data.address_title = value; }
        }

        public string address_line1
        {
            get { return data.address_line1; }
            set { data.address_line1 = value; }
        }

        public string address_line2
        {
            get { return data.address_line2; }
            set { data.address_line2 = value; }
        }

        public string city
        {
            get { return data.city; }
            set { data.city = value; }
        }

        public string county
        {
            get { return data.county; }
            set { data.county = value; }
        }

        public string state
        {
            get { return data.state; }
            set { data.state = value; }
        }

        public string country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        public string pincode
        {
            get { return data.pincode; }
            set { data.pincode = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }

        public string phone
        {
            get { return data.phone; }
            set { data.phone = value; }
        }

        public string mobile_no
        {
            get { return data.mobile_no; }
            set { data.mobile_no = value; }
        }

        public string fax
        {
            get { return data.fax; }
            set { data.fax = value; }
        }

        public Type type
        {
            get { return parseEnum<Type>(data.type); }
            set { data.type = value.ToString(); }
        }

        public string market_segment
        {
            get { return data.market_segment; }
            set { data.market_segment = value; }
        }

        public string industry
        {
            get { return data.industry; }
            set { data.industry = value; }
        }

        public Requesttype request_type
        {
            get { return parseEnum<Requesttype>(data.request_type); }
            set { data.request_type = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        public long unsubscribed
        {
            get { return data.unsubscribed; }
            set { data.unsubscribed = value; }
        }

        public long blog_subscriber
        {
            get { return data.blog_subscriber; }
            set { data.blog_subscriber = value; }
        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public Addresstype address_type
        {
            get { return parseEnum<Addresstype>(data.address_type); }
            set { data.address_type = value.ToString(); }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Lead")]
        Lead,
        [Description("Open")]
        Open,
        [Description("Replied")]
        Replied,
        [Description("Opportunity")]
        Opportunity,
        [Description("Quotation")]
        Quotation,
        [Description("Lost Quotation")]
        LostQuotation,
        [Description("Interested")]
        Interested,
        [Description("Converted")]
        Converted,
        [Description("Do Not Contact")]
        DoNotContact,
    }

    public enum Type
    {
        [Description("Client")]
        Client,
        [Description("Channel Partner")]
        ChannelPartner,
        [Description("Consultant")]
        Consultant,
    }

    public enum Requesttype
    {
        [Description("Product Enquiry")]
        ProductEnquiry,
        [Description("Request for Information")]
        RequestforInformation,
        [Description("Suggestions")]
        Suggestions,
        [Description("Other")]
        Other,
    }

    public enum Addresstype
    {
        [Description("Billing")]
        Billing,
        [Description("Shipping")]
        Shipping,
        [Description("Office")]
        Office,
        [Description("Personal")]
        Personal,
        [Description("Plant")]
        Plant,
        [Description("Postal")]
        Postal,
        [Description("Shop")]
        Shop,
        [Description("Subsidiary")]
        Subsidiary,
        [Description("Warehouse")]
        Warehouse,
        [Description("Current")]
        Current,
        [Description("Permanent")]
        Permanent,
        [Description("Other")]
        Other,
    }


}