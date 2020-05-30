using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Selling_settings
{
    public class ERPSelling_settings : ERPNextObjectBase
    {
        public ERPSelling_settings() : this(new ERPObject(DocType.Selling_settings)) { }
        public ERPSelling_settings(ERPObject obj) : base(obj) { }

        public static ERPSelling_settings Create(Salesupdatefrequency salesupdatefrequency)

        {
            ERPSelling_settings obj = new ERPSelling_settings();
            obj.sales_update_frequency = salesupdatefrequency;
            return obj;
        }

        public Salesupdatefrequency sales_update_frequency
        {
            get { return parseEnum<Salesupdatefrequency>(data.sales_update_frequency); }
            set { data.sales_update_frequency = value.ToString(); }
        }

        public Custmastername cust_master_name
        {
            get { return parseEnum<Custmastername>(data.cust_master_name); }
            set { data.cust_master_name = value.ToString(); }
        }

        public Campaignnamingby campaign_naming_by
        {
            get { return parseEnum<Campaignnamingby>(data.campaign_naming_by); }
            set { data.campaign_naming_by = value.ToString(); }
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

        public string selling_price_list
        {
            get { return data.selling_price_list; }
            set { data.selling_price_list = value; }
        }

        private int _close_opportunity_after_days = 0;
        public int close_opportunity_after_days
        {
            get { return data._close_opportunity_after_days; }
            set { data._close_opportunity_after_days = value; }
        }

        public string default_valid_till
        {
            get { return data.default_valid_till; }
            set { data.default_valid_till = value; }
        }

        public Sorequired so_required
        {
            get { return parseEnum<Sorequired>(data.so_required); }
            set { data.so_required = value.ToString(); }
        }

        public Dnrequired dn_required
        {
            get { return parseEnum<Dnrequired>(data.dn_required); }
            set { data.dn_required = value.ToString(); }
        }

        private int _maintain_same_sales_rate = 0;
        public int maintain_same_sales_rate
        {
            get { return data._maintain_same_sales_rate; }
            set { data._maintain_same_sales_rate = value; }
        }

        private int _editable_price_list_rate = 0;
        public int editable_price_list_rate
        {
            get { return data._editable_price_list_rate; }
            set { data._editable_price_list_rate = value; }
        }

        private int _allow_multiple_items = 0;
        public int allow_multiple_items
        {
            get { return data._allow_multiple_items; }
            set { data._allow_multiple_items = value; }
        }

        private int _allow_against_multiple_purchase_orders = 0;
        public int allow_against_multiple_purchase_orders
        {
            get { return data._allow_against_multiple_purchase_orders; }
            set { data._allow_against_multiple_purchase_orders = value; }
        }

        private int _validate_selling_price = 0;
        public int validate_selling_price
        {
            get { return data._validate_selling_price; }
            set { data._validate_selling_price = value; }
        }

        private int _hide_tax_id = 0;
        public int hide_tax_id
        {
            get { return data._hide_tax_id; }
            set { data._hide_tax_id = value; }
        }


    }

    //Enums go here
    public enum Salesupdatefrequency
    {
        [Description("Each Transaction")]
        EachTransaction,
        [Description("Daily")]
        Daily,
        [Description("Monthly")]
        Monthly,
    }

    public enum Custmastername
    {
        [Description("Customer Name")]
        CustomerName,
        [Description("Naming Series")]
        NamingSeries,
    }

    public enum Campaignnamingby
    {
        [Description("Campaign Name")]
        CampaignName,
        [Description("Naming Series")]
        NamingSeries,
    }

    public enum Sorequired
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }

    public enum Dnrequired
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }


}