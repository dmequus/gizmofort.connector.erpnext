using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Promotional_scheme_price_discount
{
    public class ERPPromotional_scheme_price_discount : ERPNextObjectBase
    {
        public ERPPromotional_scheme_price_discount() : this(new ERPObject(DocType.Promotional_scheme_price_discount)) { }
        public ERPPromotional_scheme_price_discount(ERPObject obj) : base(obj) { }

        public static ERPPromotional_scheme_price_discount Create(long disable, string ruledescription, double minqty, double maxqty, double minamount, double maxamount, Rateordiscount rateordiscount, double rate, double discountamount, double discountpercentage, string warehouse, double thresholdpercentage, long validateappliedrule, Priority priority, long applymultiplepricingrules, long applydiscountonrate)

        {
            ERPPromotional_scheme_price_discount obj = new ERPPromotional_scheme_price_discount();
            obj.disable = disable;
            obj.rule_description = ruledescription;
            obj.min_qty = minqty;
            obj.max_qty = maxqty;
            obj.min_amount = minamount;
            obj.max_amount = maxamount;
            obj.rate_or_discount = rateordiscount;
            obj.rate = rate;
            obj.discount_amount = discountamount;
            obj.discount_percentage = discountpercentage;
            obj.warehouse = warehouse;
            obj.threshold_percentage = thresholdpercentage;
            obj.validate_applied_rule = validateappliedrule;
            obj.priority = priority;
            obj.apply_multiple_pricing_rules = applymultiplepricingrules;
            obj.apply_discount_on_rate = applydiscountonrate;
            return obj;
        }

        public long disable
        {
            get { return data.disable; }
            set { data.disable = value; }
        }

        public string rule_description
        {
            get { return data.rule_description; }
            set { data.rule_description = value; }
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

        public double min_amount
        {
            get { return data.min_amount; }
            set { data.min_amount = value; }
        }

        public double max_amount
        {
            get { return data.max_amount; }
            set { data.max_amount = value; }
        }

        public Rateordiscount rate_or_discount
        {
            get { return parseEnum<Rateordiscount>(data.rate_or_discount); }
            set { data.rate_or_discount = value.ToString(); }
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

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public double threshold_percentage
        {
            get { return data.threshold_percentage; }
            set { data.threshold_percentage = value; }
        }

        public long validate_applied_rule
        {
            get { return data.validate_applied_rule; }
            set { data.validate_applied_rule = value; }
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


    }

    //Enums go here
    public enum Rateordiscount
    {
        [Description("Rate")]
        Rate,
        [Description("Discount Percentage")]
        DiscountPercentage,
        [Description("Discount Amount")]
        DiscountAmount,
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