using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_attendance_tool
{
    public class Employee_attendance_toolService : SubServiceBase<ERPEmployee_attendance_tool>
    {
        public Employee_attendance_toolService(ERPNextClient client)
            : base(DocType.Employee_attendance_tool, client) { }

        protected override ERPEmployee_attendance_tool fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_attendance_tool(obj);
        }
    }
}