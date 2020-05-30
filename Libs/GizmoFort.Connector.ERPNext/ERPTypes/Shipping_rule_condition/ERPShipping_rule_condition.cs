using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shipping_rule_condition
{
    public class ERPShipping_rule_condition : ERPNextObjectBase
    {
        public ERPShipping_rule_condition() : this(new ERPObject(DocType.Shipping_rule_condition)) { }
        public ERPShipping_rule_condition(ERPObject obj) : base(obj) { }

        public static ERPShipping_rule_condition Create(double fromvalue, double tovalue, double shippingamount)

        {
            ERPShipping_rule_condition obj = new ERPShipping_rule_condition();
            obj.from_value = fromvalue;
            obj.to_value = tovalue;
            obj.shipping_amount = shippingamount;
            return obj;
        }

        public double from_value
        {
            get { return data.from_value; }
            set { data.from_value = value; }
        }

        public double to_value
        {
            get { return data.to_value; }
            set { data.to_value = value; }
        }

        public double shipping_amount
        {
            get { return data.shipping_amount; }
            set { data.shipping_amount = value; }
        }


    }

    //Enums go here

}