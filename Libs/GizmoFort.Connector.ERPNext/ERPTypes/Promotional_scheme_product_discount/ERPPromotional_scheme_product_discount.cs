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

        public long disable
        {
            get { return data.disable; }
            set { data.disable = value; }
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