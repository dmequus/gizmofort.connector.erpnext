using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_item_code
{
    public class ERPPricing_rule_item_code : ERPNextObjectBase
    {
        public ERPPricing_rule_item_code() : this(new ERPObject(DocType.Pricing_rule_item_code)) { }
        public ERPPricing_rule_item_code(ERPObject obj) : base(obj) { }

        public static ERPPricing_rule_item_code Create(string itemcode, string uom)

        {
            ERPPricing_rule_item_code obj = new ERPPricing_rule_item_code();
            obj.item_code = itemcode;
            obj.uom = uom;
            return obj;
        }

        public string item_code
        {
            get { return data.item_code; }
            set
            {
                data.item_code = value;
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