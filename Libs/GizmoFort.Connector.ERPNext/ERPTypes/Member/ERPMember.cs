using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Member
{
    public class ERPMember : ERPNextObjectBase
    {
        public ERPMember() : this(new ERPObject(DocType.Member)) { }
        public ERPMember(ERPObject obj) : base(obj) { }

        public static ERPMember Create(string membername, string namingseries, string membershiptype)

        {
            ERPMember obj = new ERPMember();
            obj.member_name = membername;
            obj.naming_series = namingseries;
            obj.membership_type = membershiptype;
            return obj;
        }

        public string member_name
        {
            get { return data.member_name; }
            set
            {
                data.member_name = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string membership_type
        {
            get { return data.membership_type; }
            set { data.membership_type = value; }
        }

        public string membership_expiry_date
        {
            get { return data.membership_expiry_date; }
            set { data.membership_expiry_date = value; }
        }

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
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

        public string email_id
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        public string subscription_id
        {
            get { return data.subscription_id; }
            set { data.subscription_id = value; }
        }

        public string customer_id
        {
            get { return data.customer_id; }
            set { data.customer_id = value; }
        }

        private int _subscription_activated = 0;
        public int subscription_activated
        {
            get { return data._subscription_activated; }
            set { data._subscription_activated = value; }
        }

        public string subscription_start
        {
            get { return data.subscription_start; }
            set { data.subscription_start = value; }
        }

        public string subscription_end
        {
            get { return data.subscription_end; }
            set { data.subscription_end = value; }
        }


    }

    //Enums go here

}