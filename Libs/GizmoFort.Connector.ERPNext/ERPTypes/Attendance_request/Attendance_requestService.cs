using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Attendance_request
{
    public class Attendance_requestService : SubServiceBase<ERPAttendance_request>
    {
        public Attendance_requestService(ERPNextClient client)
            : base(DocType.Attendance_request, client) { }

        protected override ERPAttendance_request fromERPObject(ERPObject obj)
        {
            return new ERPAttendance_request(obj);
        }
    }
}