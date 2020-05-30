using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Promotional_scheme
{
    public class ERPPromotional_scheme : ERPNextObjectBase
    {
        public ERPPromotional_scheme() : this(new ERPObject(DocType.Promotional_scheme)) { }
        public ERPPromotional_scheme(ERPObject obj) : base(obj) { }

        public static ERPPromotional_scheme Create(Applyon applyon, int disable, string items, string itemgroups, string brands, int mixedconditions, int iscumulative, Applyruleonother applyruleonother, string otheritemcode, string otheritemgroup, string otherbrand, int selling, int buying, Applicablefor applicablefor, string customer, string customergroup, string territory, string salespartner, string campaign, string supplier, string suppliergroup, string validfrom, string validupto, string company, string currency, string pricediscountslabs, string productdiscountslabs)

        {
            ERPPromotional_scheme obj = new ERPPromotional_scheme();
            obj.apply_on = applyon;
            obj.disable = disable;
            obj.items = items;
            obj.item_groups = itemgroups;
            obj.brands = brands;
            obj.mixed_conditions = mixedconditions;
            obj.is_cumulative = iscumulative;
            obj.apply_rule_on_other = applyruleonother;
            obj.other_item_code = otheritemcode;
            obj.other_item_group = otheritemgroup;
            obj.other_brand = otherbrand;
            obj.selling = selling;
            obj.buying = buying;
            obj.applicable_for = applicablefor;
            obj.customer = customer;
            obj.customer_group = customergroup;
            obj.territory = territory;
            obj.sales_partner = salespartner;
            obj.campaign = campaign;
            obj.supplier = supplier;
            obj.supplier_group = suppliergroup;
            obj.valid_from = validfrom;
            obj.valid_upto = validupto;
            obj.company = company;
            obj.currency = currency;
            obj.price_discount_slabs = pricediscountslabs;
            obj.product_discount_slabs = productdiscountslabs;
            return obj;
        }

        public Applyon apply_on
        {
            get { return parseEnum<Applyon>(data.apply_on); }
            set { data.apply_on = value.ToString(); }
        }

        private int _disable = 0;
        public int disable
        {
            get { return data._disable; }
            set { data._disable = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string item_groups
        {
            get { return data.item_groups; }
            set { data.item_groups = value; }
        }

        public string brands
        {
            get { return data.brands; }
            set { data.brands = value; }
        }

        private int _mixed_conditions = 0;
        public int mixed_conditions
        {
            get { return data._mixed_conditions; }
            set { data._mixed_conditions = value; }
        }

        private int _is_cumulative = 0;
        public int is_cumulative
        {
            get { return data._is_cumulative; }
            set { data._is_cumulative = value; }
        }

        public Applyruleonother apply_rule_on_other
        {
            get { return parseEnum<Applyruleonother>(data.apply_rule_on_other); }
            set { data.apply_rule_on_other = value.ToString(); }
        }

        public string other_item_code
        {
            get { return data.other_item_code; }
            set { data.other_item_code = value; }
        }

        public string other_item_group
        {
            get { return data.other_item_group; }
            set { data.other_item_group = value; }
        }

        public string other_brand
        {
            get { return data.other_brand; }
            set { data.other_brand = value; }
        }

        private int _selling = 0;
        public int selling
        {
            get { return data._selling; }
            set { data._selling = value; }
        }

        private int _buying = 0;
        public int buying
        {
            get { return data._buying; }
            set { data._buying = value; }
        }

        public Applicablefor applicable_for
        {
            get { return parseEnum<Applicablefor>(data.applicable_for); }
            set { data.applicable_for = value.ToString(); }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
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

        public string sales_partner
        {
            get { return data.sales_partner; }
            set { data.sales_partner = value; }
        }

        public string campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string supplier_group
        {
            get { return data.supplier_group; }
            set { data.supplier_group = value; }
        }

        public string valid_from
        {
            get { return data.valid_from; }
            set { data.valid_from = value; }
        }

        public string valid_upto
        {
            get { return data.valid_upto; }
            set { data.valid_upto = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public string price_discount_slabs
        {
            get { return data.price_discount_slabs; }
            set { data.price_discount_slabs = value; }
        }

        public string product_discount_slabs
        {
            get { return data.product_discount_slabs; }
            set { data.product_discount_slabs = value; }
        }


    }

    //Enums go here
    public enum Applyon
    {
        [Description("Item Code")]
        ItemCode,
        [Description("Item Group")]
        ItemGroup,
        [Description("Brand")]
        Brand,
        [Description("Transaction")]
        Transaction,
    }

    public enum Applyruleonother
    {
        [Description("Item Code")]
        ItemCode,
        [Description("Item Group")]
        ItemGroup,
        [Description("Brand")]
        Brand,
    }

    public enum Applicablefor
    {
        [Description("Customer")]
        Customer,
        [Description("Customer Group")]
        CustomerGroup,
        [Description("Territory")]
        Territory,
        [Description("Sales Partner")]
        SalesPartner,
        [Description("Campaign")]
        Campaign,
        [Description("Supplier")]
        Supplier,
        [Description("Supplier Group")]
        SupplierGroup,
    }


}