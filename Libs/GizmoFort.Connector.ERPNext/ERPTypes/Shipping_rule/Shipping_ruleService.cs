using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shipping_rule
{
    public class Shipping_ruleService : SubServiceBase<ERPShipping_rule>
    {
        public Shipping_ruleService(ERPNextClient client)
            : base(DocType.Shipping_rule, client) { }

        protected override ERPShipping_rule fromERPObject(ERPObject obj)
        {
            return new ERPShipping_rule(obj);
        }
    }
}