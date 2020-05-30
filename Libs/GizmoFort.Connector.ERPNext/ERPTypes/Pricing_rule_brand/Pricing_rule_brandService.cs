using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_brand
{
    public class Pricing_rule_brandService : SubServiceBase<ERPPricing_rule_brand>
    {
        public Pricing_rule_brandService(ERPNextClient client)
            : base(DocType.Pricing_rule_brand, client) { }

        protected override ERPPricing_rule_brand fromERPObject(ERPObject obj)
        {
            return new ERPPricing_rule_brand(obj);
        }
    }
}