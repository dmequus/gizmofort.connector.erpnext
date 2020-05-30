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

        public long disable
        {
            get { return data.disable; }
            set { data.disable = value; }
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

        public long mixed_conditions
        {
            get { return data.mixed_conditions; }
            set { data.mixed_conditions = value; }
        }

        public long is_cumulative
        {
            get { return data.is_cumulative; }
            set { data.is_cumulative = value; }
        }

        public long coupon_code_based
        {
            get { return data.coupon_code_based; }
            set { data.coupon_code_based = value; }
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

        public long selling
        {
            get { return data.selling; }
            set { data.selling = value; }
        }

        public long buying
        {
            get { return data.buying; }
            set { data.buying = value; }
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

        public double min_qty
        {
            get { return data.min_qty; }
            set { data.min_qty = value; }
        }

        public double max_qty
        {
            get { return data.max_qty; }
            set { data.max_qty = value; }
        }

        public double min_amt
        {
            get { return data.min_amt; }
            set { data.min_amt = value; }
        }

        public double max_amt
        {
            get { return data.max_amt; }
            set { data.max_amt = value; }
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

        public double margin_rate_or_amount
        {
            get { return data.margin_rate_or_amount; }
            set { data.margin_rate_or_amount = value; }
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

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public double discount_amount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        public double discount_percentage
        {
            get { return data.discount_percentage; }
            set { data.discount_percentage = value; }
        }

        public string for_price_list
        {
            get { return data.for_price_list; }
            set { data.for_price_list = value; }
        }

        public long same_item
        {
            get { return data.same_item; }
            set { data.same_item = value; }
        }

        public string free_item
        {
            get { return data.free_item; }
            set { data.free_item = value; }
        }

        public double free_qty
        {
            get { return data.free_qty; }
            set { data.free_qty = value; }
        }

        public string free_item_uom
        {
            get { return data.free_item_uom; }
            set { data.free_item_uom = value; }
        }

        public double free_item_rate
        {
            get { return data.free_item_rate; }
            set { data.free_item_rate = value; }
        }

        public double threshold_percentage
        {
            get { return data.threshold_percentage; }
            set { data.threshold_percentage = value; }
        }

        public Priority priority
        {
            get { return parseEnum<Priority>(data.priority); }
            set { data.priority = value.ToString(); }
        }

        public long apply_multiple_pricing_rules
        {
            get { return data.apply_multiple_pricing_rules; }
            set { data.apply_multiple_pricing_rules = value; }
        }

        public long apply_discount_on_rate
        {
            get { return data.apply_discount_on_rate; }
            set { data.apply_discount_on_rate = value; }
        }

        public long validate_applied_rule
        {
            get { return data.validate_applied_rule; }
            set { data.validate_applied_rule = value; }
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