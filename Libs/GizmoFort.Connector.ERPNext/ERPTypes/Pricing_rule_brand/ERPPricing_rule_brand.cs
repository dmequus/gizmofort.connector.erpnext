using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_brand
{
    public class ERPPricing_rule_brand : ERPNextObjectBase
    {
        public ERPPricing_rule_brand() : this(new ERPObject(DocType.Pricing_rule_brand)) { }
        public ERPPricing_rule_brand(ERPObject obj) : base(obj) { }

        public static ERPPricing_rule_brand Create(string brand, string uom)

        {
            ERPPricing_rule_brand obj = new ERPPricing_rule_brand();
            obj.brand = brand;
            obj.uom = uom;
            return obj;
        }

        public string brand
        {
            get { return data.brand; }
            set
            {
                data.brand = value;
                data.name = value;
            }

        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }


    }

    //Enums go here

}