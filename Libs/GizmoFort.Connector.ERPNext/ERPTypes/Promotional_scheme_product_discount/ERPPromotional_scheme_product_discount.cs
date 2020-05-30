using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Promotional_scheme_product_discount
{
    public class ERPPromotional_scheme_product_discount : ERPNextObjectBase
    {
        public ERPPromotional_scheme_product_discount() : this(new ERPObject(DocType.Promotional_scheme_product_discount)) { }
        public ERPPromotional_scheme_product_discount(ERPObject obj) : base(obj) { }

        public static ERPPromotional_scheme_product_discount Create(string ruledescription)

        {
            ERPPromotional_scheme_product_discount obj = new ERPPromotional_scheme_product_discount();
            obj.rule_description = ruledescription;
            return obj;
        }

        public string rule_description
        {
            get { return data.rule_description; }
            set
            {
                data.rule_description = value;
                data.name = value;
            }

        }

        private int _disable = 0;
        public int disable
        {
            get { return data._disable; }
            set { data._disable = value; }
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


    }

    //Enums go here
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