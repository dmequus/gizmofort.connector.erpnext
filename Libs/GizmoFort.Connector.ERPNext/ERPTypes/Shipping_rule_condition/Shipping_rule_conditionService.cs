using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shipping_rule_condition
{
    public class Shipping_rule_conditionService : SubServiceBase<ERPShipping_rule_condition>
    {
        public Shipping_rule_conditionService(ERPNextClient client)
            : base(DocType.Shipping_rule_condition, client) { }

        protected override ERPShipping_rule_condition fromERPObject(ERPObject obj)
        {
            return new ERPShipping_rule_condition(obj);
        }
    }
}