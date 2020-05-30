using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_allocation
{
    public class Leave_allocationService : SubServiceBase<ERPLeave_allocation>
    {
        public Leave_allocationService(ERPNextClient client)
            : base(DocType.Leave_allocation, client) { }

        protected override ERPLeave_allocation fromERPObject(ERPObject obj)
        {
            return new ERPLeave_allocation(obj);
        }
    }
}