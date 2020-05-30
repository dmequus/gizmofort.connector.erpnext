using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_policy
{
    public class Leave_policyService : SubServiceBase<ERPLeave_policy>
    {
        public Leave_policyService(ERPNextClient client)
            : base(DocType.Leave_policy, client) { }

        protected override ERPLeave_policy fromERPObject(ERPObject obj)
        {
            return new ERPLeave_policy(obj);
        }
    }
}