using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_rule
{
    public class ERPTax_rule : ERPNextObjectBase
    {
        public ERPTax_rule() : this(new ERPObject(DocType.Tax_rule)) { }
        public ERPTax_rule(ERPObject obj) : base(obj) { }

        public static ERPTax_rule Create(Taxtype taxtype, long useforshoppingcart, string salestaxtemplate, string purchasetaxtemplate, string customer, string supplier, string item, string billingcity, string billingcounty, string billingstate, string billingzipcode, string billingcountry, string taxcategory, string customergroup, string suppliergroup, string itemgroup, string shippingcity, string shippingcounty, string shippingstate, string shippingzipcode, string shippingcountry, string fromdate, string todate, int priority, string company)

        {
            ERPTax_rule obj = new ERPTax_rule();
            obj.tax_type = taxtype;
            obj.use_for_shopping_cart = useforshoppingcart;
            obj.sales_tax_template = salestaxtemplate;
            obj.purchase_tax_template = purchasetaxtemplate;
            obj.customer = customer;
            obj.supplier = supplier;
            obj.item = item;
            obj.billing_city = billingcity;
            obj.billing_county = billingcounty;
            obj.billing_state = billingstate;
            obj.billing_zipcode = billingzipcode;
            obj.billing_country = billingcountry;
            obj.tax_category = taxcategory;
            obj.customer_group = customergroup;
            obj.supplier_group = suppliergroup;
            obj.item_group = itemgroup;
            obj.shipping_city = shippingcity;
            obj.shipping_county = shippingcounty;
            obj.shipping_state = shippingstate;
            obj.shipping_zipcode = shippingzipcode;
            obj.shipping_country = shippingcountry;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.priority = priority;
            obj.company = company;
            return obj;
        }

        public Taxtype tax_type
        {
            get { return parseEnum<Taxtype>(data.tax_type); }
            set { data.tax_type = value.ToString(); }
        }

        public long use_for_shopping_cart
        {
            get { return data.use_for_shopping_cart; }
            set { data.use_for_shopping_cart = value; }
        }

        public string sales_tax_template
        {
            get { return data.sales_tax_template; }
            set { data.sales_tax_template = value; }
        }

        public string purchase_tax_template
        {
            get { return data.purchase_tax_template; }
            set { data.purchase_tax_template = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string item
        {
            get { return data.item; }
            set { data.item = value; }
        }

        public string billing_city
        {
            get { return data.billing_city; }
            set { data.billing_city = value; }
        }

        public string billing_county
        {
            get { return data.billing_county; }
            set { data.billing_county = value; }
        }

        public string billing_state
        {
            get { return data.billing_state; }
            set { data.billing_state = value; }
        }

        public string billing_zipcode
        {
            get { return data.billing_zipcode; }
            set { data.billing_zipcode = value; }
        }

        public string billing_country
        {
            get { return data.billing_country; }
            set { data.billing_country = value; }
        }

        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string supplier_group
        {
            get { return data.supplier_group; }
            set { data.supplier_group = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public string shipping_city
        {
            get { return data.shipping_city; }
            set { data.shipping_city = value; }
        }

        public string shipping_county
        {
            get { return data.shipping_county; }
            set { data.shipping_county = value; }
        }

        public string shipping_state
        {
            get { return data.shipping_state; }
            set { data.shipping_state = value; }
        }

        public string shipping_zipcode
        {
            get { return data.shipping_zipcode; }
            set { data.shipping_zipcode = value; }
        }

        public string shipping_country
        {
            get { return data.shipping_country; }
            set { data.shipping_country = value; }
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

        public int priority
        {
            get { return data.priority; }
            set { data.priority = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }


    }

    //Enums go here
    public enum Taxtype
    {
        [Description("Sales")]
        Sales,
        [Description("Purchase")]
        Purchase,
    }


}