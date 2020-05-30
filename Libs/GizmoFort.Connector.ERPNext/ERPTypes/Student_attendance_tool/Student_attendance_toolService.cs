using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_attendance_tool
{
    public class Student_attendance_toolService : SubServiceBase<ERPStudent_attendance_tool>
    {
        public Student_attendance_toolService(ERPNextClient client)
            : base(DocType.Student_attendance_tool, client) { }

        protected override ERPStudent_attendance_tool fromERPObject(ERPObject obj)
        {
            return new ERPStudent_attendance_tool(obj);
        }
    }
}