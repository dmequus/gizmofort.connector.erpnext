using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Coupon_code
{
    public class ERPCoupon_code : ERPNextObjectBase
    {
        public ERPCoupon_code() : this(new ERPObject(DocType.Coupon_code)) { }
        public ERPCoupon_code(ERPObject obj) : base(obj) { }

        public static ERPCoupon_code Create(string couponname, Coupontype coupontype, string pricingrule)

        {
            ERPCoupon_code obj = new ERPCoupon_code();
            obj.coupon_name = couponname;
            obj.coupon_type = coupontype;
            obj.pricing_rule = pricingrule;
            return obj;
        }

        public string coupon_name
        {
            get { return data.coupon_name; }
            set
            {
                data.coupon_name = value;
                data.name = value;
            }

        }

        public Coupontype coupon_type
        {
            get { return parseEnum<Coupontype>(data.coupon_type); }
            set { data.coupon_type = value.ToString(); }
        }

        public string pricing_rule
        {
            get { return data.pricing_rule; }
            set { data.pricing_rule = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string coupon_code
        {
            get { return data.coupon_code; }
            set { data.coupon_code = value; }
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

        public int maximum_use
        {
            get { return data.maximum_use; }
            set { data.maximum_use = value; }
        }

        public int used
        {
            get { return data.used; }
            set { data.used = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Coupontype
    {
        [Description("Promotional")]
        Promotional,
        [Description("Gift Card")]
        GiftCard,
    }


}