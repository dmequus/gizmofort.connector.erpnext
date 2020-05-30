using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_attendance
{
    public class Student_attendanceService : SubServiceBase<ERPStudent_attendance>
    {
        public Student_attendanceService(ERPNextClient client)
            : base(DocType.Student_attendance, client) { }

        protected override ERPStudent_attendance fromERPObject(ERPObject obj)
        {
            return new ERPStudent_attendance(obj);
        }
    }
}