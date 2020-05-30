using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shift_assignment
{
    public class Shift_assignmentService : SubServiceBase<ERPShift_assignment>
    {
        public Shift_assignmentService(ERPNextClient client)
            : base(DocType.Shift_assignment, client) { }

        protected override ERPShift_assignment fromERPObject(ERPObject obj)
        {
            return new ERPShift_assignment(obj);
        }
    }
}