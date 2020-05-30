using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_partner
{
    public class ERPSales_partner : ERPNextObjectBase
    {
        public ERPSales_partner() : this(new ERPObject(DocType.Sales_partner)) { }
        public ERPSales_partner(ERPObject obj) : base(obj) { }

        public static ERPSales_partner Create(string partnername, string partnertype, string territory, double commissionrate, string addressdesc, string addresshtml, string contactdesc, string contacthtml, string targets, int showinwebsite, string referralcode, string route, string logo, string partnerwebsite, string introduction, string description)

        {
            ERPSales_partner obj = new ERPSales_partner();
            obj.partner_name = partnername;
            obj.partner_type = partnertype;
            obj.territory = territory;
            obj.commission_rate = commissionrate;
            obj.address_desc = addressdesc;
            obj.address_html = addresshtml;
            obj.contact_desc = contactdesc;
            obj.contact_html = contacthtml;
            obj.targets = targets;
            obj.show_in_website = showinwebsite;
            obj.referral_code = referralcode;
            obj.route = route;
            obj.logo = logo;
            obj.partner_website = partnerwebsite;
            obj.introduction = introduction;
            obj.description = description;
            return obj;
        }

        public string partner_name
        {
            get { return data.partner_name; }
            set
            {
                data.partner_name = value;
                data.name = value;
            }

        }

        public string partner_type
        {
            get { return data.partner_type; }
            set { data.partner_type = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        private double _commission_rate = 0.0;
        public double commission_rate
        {
            get { return data._commission_rate; }
            set { data._commission_rate = value; }
        }

        public string address_desc
        {
            get { return data.address_desc; }
            set { data.address_desc = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string contact_desc
        {
            get { return data.contact_desc; }
            set { data.contact_desc = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }

        public string targets
        {
            get { return data.targets; }
            set { data.targets = value; }
        }

        private int _show_in_website = 0;
        public int show_in_website
        {
            get { return data._show_in_website; }
            set { data._show_in_website = value; }
        }

        public string referral_code
        {
            get { return data.referral_code; }
            set { data.referral_code = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        public string logo
        {
            get { return data.logo; }
            set { data.logo = value; }
        }

        public string partner_website
        {
            get { return data.partner_website; }
            set { data.partner_website = value; }
        }

        public string introduction
        {
            get { return data.introduction; }
            set { data.introduction = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}