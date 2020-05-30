using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule
{
    public class ERPPricing_rule : ERPNextObjectBase
    {
        public ERPPricing_rule() : this(new ERPObject(DocType.Pricing_rule)) { }
        public ERPPricing_rule(ERPObject obj) : base(obj) { }

        public static ERPPricing_rule Create(string title, Applyon applyon, Priceorproductdiscount priceorproductdiscount, string currency)

        {
            ERPPricing_rule obj = new ERPPricing_rule();
            obj.title = title;
            obj.apply_on = applyon;
            obj.price_or_product_discount = priceorproductdiscount;
            obj.currency = currency;
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

        public Applyon apply_on
        {
            get { return parseEnum<Applyon>(data.apply_on); }
            set { data.apply_on = value.ToString(); }
        }

        public Priceorproductdiscount price_or_product_discount
        {
            get { return parseEnum<Priceorproductdiscount>(data.price_or_product_discount); }
            set { data.price_or_product_discount = value.ToString(); }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        private int _disable = 0;
        public int disable
        {
            get { return data._disable; }
            set { data._disable = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
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

        private int _coupon_code_based = 0;
        public int coupon_code_based
        {
            get { return data._coupon_code_based; }
            set { data._coupon_code_based = value; }
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

        private double _min_qty = 0.0;
        public double min_qty
        {
            get { return data._min_qty; }
            set { data._min_qty = value; }
        }

        private double _max_qty = 0.0;
        public double max_qty
        {
            get { return data._max_qty; }
            set { data._max_qty = value; }
        }

        private double _min_amt = 0.0;
        public double min_amt
        {
            get { return data._min_amt; }
            set { data._min_amt = value; }
        }

        private double _max_amt = 0.0;
        public double max_amt
        {
            get { return data._max_amt; }
            set { data._max_amt = value; }
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

        public Margintype margin_type
        {
            get { return parseEnum<Margintype>(data.margin_type); }
            set { data.margin_type = value.ToString(); }
        }

        private double _margin_rate_or_amount = 0.0;
        public double margin_rate_or_amount
        {
            get { return data._margin_rate_or_amount; }
            set { data._margin_rate_or_amount = value; }
        }

        public Rateordiscount rate_or_discount
        {
            get { return parseEnum<Rateordiscount>(data.rate_or_discount); }
            set { data.rate_or_discount = value.ToString(); }
        }

        public Applydiscounton apply_discount_on
        {
            get { return parseEnum<Applydiscounton>(data.apply_discount_on); }
            set { data.apply_discount_on = value.ToString(); }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private double _discount_amount = 0.0;
        public double discount_amount
        {
            get { return data._discount_amount; }
            set { data._discount_amount = value; }
        }

        private double _discount_percentage = 0.0;
        public double discount_percentage
        {
            get { return data._discount_percentage; }
            set { data._discount_percentage = value; }
        }

        public string for_price_list
        {
            get { return data.for_price_list; }
            set { data.for_price_list = value; }
        }

        private int _same_item = 0;
        public int same_item
        {
            get { return data._same_item; }
            set { data._same_item = value; }
        }

        public string free_item
        {
            get { return data.free_item; }
            set { data.free_item = value; }
        }

        private double _free_qty = 0.0;
        public double free_qty
        {
            get { return data._free_qty; }
            set { data._free_qty = value; }
        }

        public string free_item_uom
        {
            get { return data.free_item_uom; }
            set { data.free_item_uom = value; }
        }

        private double _free_item_rate = 0.0;
        public double free_item_rate
        {
            get { return data._free_item_rate; }
            set { data._free_item_rate = value; }
        }

        private double _threshold_percentage = 0.0;
        public double threshold_percentage
        {
            get { return data._threshold_percentage; }
            set { data._threshold_percentage = value; }
        }

        public Priority priority
        {
            get { return parseEnum<Priority>(data.priority); }
            set { data.priority = value.ToString(); }
        }

        private int _apply_multiple_pricing_rules = 0;
        public int apply_multiple_pricing_rules
        {
            get { return data._apply_multiple_pricing_rules; }
            set { data._apply_multiple_pricing_rules = value; }
        }

        private int _apply_discount_on_rate = 0;
        public int apply_discount_on_rate
        {
            get { return data._apply_discount_on_rate; }
            set { data._apply_discount_on_rate = value; }
        }

        private int _validate_applied_rule = 0;
        public int validate_applied_rule
        {
            get { return data._validate_applied_rule; }
            set { data._validate_applied_rule = value; }
        }

        public string rule_description
        {
            get { return data.rule_description; }
            set { data.rule_description = value; }
        }

        public string pricing_rule_help
        {
            get { return data.pricing_rule_help; }
            set { data.pricing_rule_help = value; }
        }

        public string promotional_scheme_id
        {
            get { return data.promotional_scheme_id; }
            set { data.promotional_scheme_id = value; }
        }

        public string promotional_scheme
        {
            get { return data.promotional_scheme; }
            set { data.promotional_scheme = value; }
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

    public enum Priceorproductdiscount
    {
        [Description("Price")]
        Price,
        [Description("Product")]
        Product,
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

    public enum Margintype
    {
        [Description("Percentage")]
        Percentage,
        [Description("Amount")]
        Amount,
    }

    public enum Rateordiscount
    {
        [Description("Rate")]
        Rate,
        [Description("Discount Percentage")]
        DiscountPercentage,
        [Description("Discount Amount")]
        DiscountAmount,
    }

    public enum Applydiscounton
    {
        [Description("Grand Total")]
        GrandTotal,
        [Description("Net Total")]
        NetTotal,
    }

    public enum Priority
    {
        [Description("1")]
        num1,
        [Description("2")]
        num2,
        [Description("3")]
        num3,
        [Description("4")]
        num4,
        [Description("5")]
        num5,
        [Description("6")]
        num6,
        [Description("7")]
        num7,
        [Description("8")]
        num8,
        [Description("9")]
        num9,
        [Description("10")]
        num10,
        [Description("11")]
        num11,
        [Description("12")]
        num12,
        [Description("13")]
        num13,
        [Description("14")]
        num14,
        [Description("15")]
        num15,
        [Description("16")]
        num16,
        [Description("17")]
        num17,
        [Description("18")]
        num18,
        [Description("19")]
        num19,
        [Description("20")]
        num20,
    }


}