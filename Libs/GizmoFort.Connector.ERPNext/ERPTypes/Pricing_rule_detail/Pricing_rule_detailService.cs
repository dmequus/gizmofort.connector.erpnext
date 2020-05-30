using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_detail
{
    public class Pricing_rule_detailService : SubServiceBase<ERPPricing_rule_detail>
    {
        public Pricing_rule_detailService(ERPNextClient client)
            : base(DocType.Pricing_rule_detail, client) { }

        protected override ERPPricing_rule_detail fromERPObject(ERPObject obj)
        {
            return new ERPPricing_rule_detail(obj);
        }
    }
}