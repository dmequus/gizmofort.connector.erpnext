using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_item_code
{
    public class Pricing_rule_item_codeService : SubServiceBase<ERPPricing_rule_item_code>
    {
        public Pricing_rule_item_codeService(ERPNextClient client)
            : base(DocType.Pricing_rule_item_code, client) { }

        protected override ERPPricing_rule_item_code fromERPObject(ERPObject obj)
        {
            return new ERPPricing_rule_item_code(obj);
        }
    }
}