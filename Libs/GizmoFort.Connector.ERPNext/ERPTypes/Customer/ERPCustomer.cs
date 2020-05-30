using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Customer
{
    public class ERPCustomer : ERPNextObjectBase
    {
        public ERPCustomer() : this(new ERPObject(DocType.Customer)) { }
        public ERPCustomer(ERPObject obj) : base(obj) { }

        public static ERPCustomer Create(string customername, Customertype customertype, string customergroup, string territory)

        {
            ERPCustomer obj = new ERPCustomer();
            obj.customer_name = customername;
            obj.customer_type = customertype;
            obj.customer_group = customergroup;
            obj.territory = territory;
            return obj;
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set
            {
                data.customer_name = value;
                data.name = value;
            }

        }

        public Customertype customer_type
        {
            get { return parseEnum<Customertype>(data.customer_type); }
            set { data.customer_type = value.ToString(); }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
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

        public string default_bank_account
        {
            get { return data.default_bank_account; }
            set { data.default_bank_account = value; }
        }

        public string lead_name
        {
            get { return data.lead_name; }
            set { data.lead_name = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string account_manager
        {
            get { return data.account_manager; }
            set { data.account_manager = value; }
        }

        public string tax_id
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
        }

        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public long is_internal_customer
        {
            get { return data.is_internal_customer; }
            set { data.is_internal_customer = value; }
        }

        public string represents_company
        {
            get { return data.represents_company; }
            set { data.represents_company = value; }
        }

        public string companies
        {
            get { return data.companies; }
            set { data.companies = value; }
        }

        public string default_currency
        {
            get { return data.default_currency; }
            set { data.default_currency = value; }
        }

        public string default_price_list
        {
            get { return data.default_price_list; }
            set { data.default_price_list = value; }
        }

        public string language
        {
            get { return data.language; }
            set { data.language = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }

        public string customer_primary_contact
        {
            get { return data.customer_primary_contact; }
            set { data.customer_primary_contact = value; }
        }

        public string mobile_no
        {
            get { return data.mobile_no; }
            set { data.mobile_no = value; }
        }

        public string email_id
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        public string customer_primary_address
        {
            get { return data.customer_primary_address; }
            set { data.customer_primary_address = value; }
        }

        public string primary_address
        {
            get { return data.primary_address; }
            set { data.primary_address = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public string payment_terms
        {
            get { return data.payment_terms; }
            set { data.payment_terms = value; }
        }

        public string customer_details
        {
            get { return data.customer_details; }
            set { data.customer_details = value; }
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

        public long is_frozen
        {
            get { return data.is_frozen; }
            set { data.is_frozen = value; }
        }

        public string loyalty_program
        {
            get { return data.loyalty_program; }
            set { data.loyalty_program = value; }
        }

        public string loyalty_program_tier
        {
            get { return data.loyalty_program_tier; }
            set { data.loyalty_program_tier = value; }
        }

        public string default_sales_partner
        {
            get { return data.default_sales_partner; }
            set { data.default_sales_partner = value; }
        }

        public double default_commission_rate
        {
            get { return data.default_commission_rate; }
            set { data.default_commission_rate = value; }
        }

        public string sales_team
        {
            get { return data.sales_team; }
            set { data.sales_team = value; }
        }

        public string customer_pos_id
        {
            get { return data.customer_pos_id; }
            set { data.customer_pos_id = value; }
        }

        public string credit_limits
        {
            get { return data.credit_limits; }
            set { data.credit_limits = value; }
        }

        public long so_required
        {
            get { return data.so_required; }
            set { data.so_required = value; }
        }

        public long dn_required
        {
            get { return data.dn_required; }
            set { data.dn_required = value; }
        }


    }

    //Enums go here
    public enum Customertype
    {
        [Description("Company")]
        Company,
        [Description("Individual")]
        Individual,
    }


}