using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_item_group
{
    public class Pricing_rule_item_groupService : SubServiceBase<ERPPricing_rule_item_group>
    {
        public Pricing_rule_item_groupService(ERPNextClient client)
            : base(DocType.Pricing_rule_item_group, client) { }

        protected override ERPPricing_rule_item_group fromERPObject(ERPObject obj)
        {
            return new ERPPricing_rule_item_group(obj);
        }
    }
}