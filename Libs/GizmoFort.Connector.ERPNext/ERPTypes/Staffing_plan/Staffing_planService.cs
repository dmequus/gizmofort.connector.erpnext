using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Staffing_plan
{
    public class Staffing_planService : SubServiceBase<ERPStaffing_plan>
    {
        public Staffing_planService(ERPNextClient client)
            : base(DocType.Staffing_plan, client) { }

        protected override ERPStaffing_plan fromERPObject(ERPObject obj)
        {
            return new ERPStaffing_plan(obj);
        }
    }
}