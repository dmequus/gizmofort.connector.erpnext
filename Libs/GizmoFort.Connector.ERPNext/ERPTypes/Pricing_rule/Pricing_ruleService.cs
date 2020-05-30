using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule
{
    public class Pricing_ruleService : SubServiceBase<ERPPricing_rule>
    {
        public Pricing_ruleService(ERPNextClient client)
            : base(DocType.Pricing_rule, client) { }

        protected override ERPPricing_rule fromERPObject(ERPObject obj)
        {
            return new ERPPricing_rule(obj);
        }
    }
}