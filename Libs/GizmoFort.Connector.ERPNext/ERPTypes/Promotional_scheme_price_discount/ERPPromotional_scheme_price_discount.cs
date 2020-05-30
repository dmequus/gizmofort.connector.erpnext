using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Promotional_scheme_price_discount
{
    public class ERPPromotional_scheme_price_discount : ERPNextObjectBase
    {
        public ERPPromotional_scheme_price_discount() : this(new ERPObject(DocType.Promotional_scheme_price_discount)) { }
        public ERPPromotional_scheme_price_discount(ERPObject obj) : base(obj) { }

        public static ERPPromotional_scheme_price_discount Create(int disable, string ruledescription, double minqty, double maxqty, double minamount, double maxamount, Rateordiscount rateordiscount, double rate, double discountamount, double discountpercentage, string warehouse, double thresholdpercentage, int validateappliedrule, Priority priority, int applymultiplepricingrules, int applydiscountonrate)

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

        private int _disable = 0;
        public int disable
        {
            get { return data._disable; }
            set { data._disable = value; }
        }

        public string rule_description
        {
            get { return data.rule_description; }
            set { data.rule_description = value; }
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

        private double _min_amount = 0.0;
        public double min_amount
        {
            get { return data._min_amount; }
            set { data._min_amount = value; }
        }

        private double _max_amount = 0.0;
        public double max_amount
        {
            get { return data._max_amount; }
            set { data._max_amount = value; }
        }

        public Rateordiscount rate_or_discount
        {
            get { return parseEnum<Rateordiscount>(data.rate_or_discount); }
            set { data.rate_or_discount = value.ToString(); }
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

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        private double _threshold_percentage = 0.0;
        public double threshold_percentage
        {
            get { return data._threshold_percentage; }
            set { data._threshold_percentage = value; }
        }

        private int _validate_applied_rule = 0;
        public int validate_applied_rule
        {
            get { return data._validate_applied_rule; }
            set { data._validate_applied_rule = value; }
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