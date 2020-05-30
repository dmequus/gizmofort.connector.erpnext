using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_policy_detail
{
    public class Leave_policy_detailService : SubServiceBase<ERPLeave_policy_detail>
    {
        public Leave_policy_detailService(ERPNextClient client)
            : base(DocType.Leave_policy_detail, client) { }

        protected override ERPLeave_policy_detail fromERPObject(ERPObject obj)
        {
            return new ERPLeave_policy_detail(obj);
        }
    }
}