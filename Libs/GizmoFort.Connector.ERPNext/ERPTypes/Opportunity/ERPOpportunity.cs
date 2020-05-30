using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Opportunity
{
    public class ERPOpportunity : ERPNextObjectBase
    {
        public ERPOpportunity() : this(new ERPObject(DocType.Opportunity)) { }
        public ERPOpportunity(ERPObject obj) : base(obj) { }

        public static ERPOpportunity Create(string title, string namingseries, string opportunityfrom, string partyname, Status status, string company, string transactiondate)

        {
            ERPOpportunity obj = new ERPOpportunity();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.opportunity_from = opportunityfrom;
            obj.party_name = partyname;
            obj.status = status;
            obj.company = company;
            obj.transaction_date = transactiondate;
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

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string opportunity_from
        {
            get { return data.opportunity_from; }
            set { data.opportunity_from = value; }
        }

        public string party_name
        {
            get { return data.party_name; }
            set { data.party_name = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string opportunity_type
        {
            get { return data.opportunity_type; }
            set { data.opportunity_type = value; }
        }

        public string order_lost_reason
        {
            get { return data.order_lost_reason; }
            set { data.order_lost_reason = value; }
        }

        public double mins_to_first_response
        {
            get { return data.mins_to_first_response; }
            set { data.mins_to_first_response = value; }
        }

        public string expected_closing
        {
            get { return data.expected_closing; }
            set { data.expected_closing = value; }
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

        public string to_discuss
        {
            get { return data.to_discuss; }
            set { data.to_discuss = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public double opportunity_amount
        {
            get { return data.opportunity_amount; }
            set { data.opportunity_amount = value; }
        }

        public long with_items
        {
            get { return data.with_items; }
            set { data.with_items = value; }
        }

        public string sales_stage
        {
            get { return data.sales_stage; }
            set { data.sales_stage = value; }
        }

        public double probability
        {
            get { return data.probability; }
            set { data.probability = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string customer_address
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        public string address_display
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string contact_person
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        public string contact_display
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        public string contact_email
        {
            get { return data.contact_email; }
            set { data.contact_email = value; }
        }

        public string contact_mobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        public string source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        public string campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string lost_reasons
        {
            get { return data.lost_reasons; }
            set { data.lost_reasons = value; }
        }

        public string converted_by
        {
            get { return data.converted_by; }
            set { data.converted_by = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Quotation")]
        Quotation,
        [Description("Converted")]
        Converted,
        [Description("Lost")]
        Lost,
        [Description("Replied")]
        Replied,
        [Description("Closed")]
        Closed,
    }


}