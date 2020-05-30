using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_item_group
{
    public class ERPPricing_rule_item_group : ERPNextObjectBase
    {
        public ERPPricing_rule_item_group() : this(new ERPObject(DocType.Pricing_rule_item_group)) { }
        public ERPPricing_rule_item_group(ERPObject obj) : base(obj) { }

        public static ERPPricing_rule_item_group Create(string itemgroup, string uom)

        {
            ERPPricing_rule_item_group obj = new ERPPricing_rule_item_group();
            obj.item_group = itemgroup;
            obj.uom = uom;
            return obj;
        }

        public string item_group
        {
            get { return data.item_group; }
            set
            {
                data.item_group = value;
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