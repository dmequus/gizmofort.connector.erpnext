using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Membership
{
    public class ERPMembership : ERPNextObjectBase
    {
        public ERPMembership() : this(new ERPObject(DocType.Membership)) { }
        public ERPMembership(ERPObject obj) : base(obj) { }

        public static ERPMembership Create(string membershiptype, string fromdate, string todate)

        {
            ERPMembership obj = new ERPMembership();
            obj.membership_type = membershiptype;
            obj.from_date = fromdate;
            obj.to_date = todate;
            return obj;
        }

        public string membership_type
        {
            get { return data.membership_type; }
            set
            {
                data.membership_type = value;
                data.name = value;
            }

        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public string member
        {
            get { return data.member; }
            set { data.member = value; }
        }

        public Membershipstatus membership_status
        {
            get { return parseEnum<Membershipstatus>(data.membership_status); }
            set { data.membership_status = value.ToString(); }
        }

        public string member_since_date
        {
            get { return data.member_since_date; }
            set { data.member_since_date = value; }
        }

        public long paid
        {
            get { return data.paid; }
            set { data.paid = value; }
        }

        public Currency currency
        {
            get { return parseEnum<Currency>(data.currency); }
            set { data.currency = value.ToString(); }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public string subscription_id
        {
            get { return data.subscription_id; }
            set { data.subscription_id = value; }
        }

        public string payment_id
        {
            get { return data.payment_id; }
            set { data.payment_id = value; }
        }

        public string webhook_payload
        {
            get { return data.webhook_payload; }
            set { data.webhook_payload = value; }
        }


    }

    //Enums go here
    public enum Membershipstatus
    {
        [Description("New")]
        New,
        [Description("Current")]
        Current,
        [Description("Expired")]
        Expired,
        [Description("Pending")]
        Pending,
        [Description("Cancelled")]
        Cancelled,
    }

    public enum Currency
    {
        [Description("USD")]
        USD,
        [Description("INR")]
        INR,
    }


}