using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Authorization_rule
{
    public class Authorization_ruleService : SubServiceBase<ERPAuthorization_rule>
    {
        public Authorization_ruleService(ERPNextClient client)
            : base(DocType.Authorization_rule, client) { }

        protected override ERPAuthorization_rule fromERPObject(ERPObject obj)
        {
            return new ERPAuthorization_rule(obj);
        }
    }
}