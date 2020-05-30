using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Attendance
{
    public class AttendanceService : SubServiceBase<ERPAttendance>
    {
        public AttendanceService(ERPNextClient client)
            : base(DocType.Attendance, client) { }

        protected override ERPAttendance fromERPObject(ERPObject obj)
        {
            return new ERPAttendance(obj);
        }
    }
}