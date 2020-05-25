/* Updated for ERPNext (version) 05-24-2020
 * 1. status no longer a field
*/

using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Customer
{
    public class ERPCustomer : ERPNextObjectBase
    {
        public ERPCustomer() : this(new ERPObject(DocType.Customer)) { }
        public ERPCustomer(ERPObject obj) : base(obj) { }

        //Mandatory
        public static ERPCustomer Create(string fullName, CustomerType customerType, string customerGroup, string territory)
        {
            ERPCustomer obj = new ERPCustomer();
            obj.customer_name = fullName;
            obj.customer_type = customerType;
            obj.customer_group = customerGroup;
            obj.territory = territory;
            return obj;
        }

        public CustomerType customer_type
        {
            get { return parseEnum<CustomerType>(data.customer_type); }
            set { data.customer_type = value.ToString(); }
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

        //Lookup
        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        //Lookup
        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        //Lookup
        public string account_manager
        {
            get { return data.account_manager; }
            set { data.account_manager = value; }
        }

        public string mobile_no
        {
            get { return data.mobile_no; }
            set { data.mobile_no = value; }
        }

        public string customer_details
        {
            get { return data.customer_details; }
            set { data.customer_details = value; }
        }

        public string tax_id
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
        }

        //Lookup
        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        public string salutation
        {
            get { return data.salutation; }
            set { data.salutation = value; }
        }

        //Lookup
        public string customer_primary_contact
        {
            get { return data.customer_primary_contact; }
            set { data.customer_primary_contact = value; }
        }

        public string market_segment
        {
            get { return data.market_segment; }
            set { data.market_segment = value; }
        }

        public string default_sales_partner
        {
            get { return data.default_sales_partner; }
            set { data.default_sales_partner = value; }
        }

        //Lookup
        public string payment_terms
        {
            get { return data.payment_terms; }
            set { data.payment_terms = value; }
        }

        public string industry
        {
            get { return data.industry; }
            set { data.industry = value; }
        }

        public string primary_address
        {
            get { return data.primary_address; }
            set { data.primary_address = value; }
        }

        public string lead_name
        {
            get { return data.lead_name; }
            set { data.lead_name = value; }
        }

        //Lookup
        public string default_currency
        {
            get { return data.default_currency; }
            set { data.default_currency = value; }
        }

        //Lookup
        public string default_price_list
        {
            get { return data.default_price_list; }
            set { data.default_price_list = value; }
        }

        public string email_id
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        //Default not disabled
        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        //Lookup
        public string default_bank_account
        {
            get { return data.default_bank_account; }
            set { data.default_bank_account = value; }
        }

        public string customer_pos_id
        {
            get { return data.customer_pos_id; }
            set { data.customer_pos_id = value; }
        }

        private int _is_frozen = 0;
        public int is_frozen
        {
            get { return data._is_frozen; }
            set { data.is_frozen = value; }
        }

        public string language
        {
            get { return data.language; }
            set { data.language = value; }
        }

        private double _default_commission_rate = 0.0;
        public double default_commission_rate
        {
            get { return data._default_commission_rate; }
            set { data._default_commission_rate = value; }
        }

        //Lookup
        public string customer_primary_address
        {
            get { return data.customer_primary_address; }
            set { data.customer_primary_address = value; }
        }

        public string represents_company
        {
            get { return data.represents_company; }
            set { data.represents_company = value; }
        }

        public string loyalty_program_tier
        {
            get { return data.loyalty_program_tier; }
            set { data.loyalty_program_tier = value; }
        }

        private string _naming_series = "CUST-.YYYY.-";
        public string naming_series
        {
            get { return data._naming_series; }
            set { data._nameing_series = value; }
        }

        private int _is_internal_customer = 0;
        public int is_internal_customer
        {
            get { return data._is_internal_customer; }
            set { data._is_internal_customer = value; }
        }

        public string gender
        {
            get { return data.gender; }
            set { data.gender = value; }
        }

        public string loyalty_program
        {
            get { return data.loyalty_program; }
            set { data.loyalty_program = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        private int _so_required = 0;
        public int so_required
        {
            get { return data._so_required; }
            set { data._so_required = value; }
        }

        private int _dn_required = 0;
        public int dn_required
        {
            get { return data._dn_required; }
            set { data._dn_required = value; }
        }
    }

    public enum CustomerType
    {
        Company,
        Individual,
    }
}