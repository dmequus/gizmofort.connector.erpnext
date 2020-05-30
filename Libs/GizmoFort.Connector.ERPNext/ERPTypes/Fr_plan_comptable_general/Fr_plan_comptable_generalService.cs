using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fr_plan_comptable_general
{
    public class Fr_plan_comptable_generalService : SubServiceBase<ERPFr_plan_comptable_general>
    {
        public Fr_plan_comptable_generalService(ERPNextClient client)
            : base(DocType.Fr_plan_comptable_general, client) { }

        protected override ERPFr_plan_comptable_general fromERPObject(ERPObject obj)
        {
            return new ERPFr_plan_comptable_general(obj);
        }
    }
}