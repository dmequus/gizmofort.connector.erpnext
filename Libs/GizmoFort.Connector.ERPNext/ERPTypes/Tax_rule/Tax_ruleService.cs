using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_rule
{
    public class Tax_ruleService : SubServiceBase<ERPTax_rule>
    {
        public Tax_ruleService(ERPNextClient client)
            : base(DocType.Tax_rule, client) { }

        protected override ERPTax_rule fromERPObject(ERPObject obj)
        {
            return new ERPTax_rule(obj);
        }
    }
}