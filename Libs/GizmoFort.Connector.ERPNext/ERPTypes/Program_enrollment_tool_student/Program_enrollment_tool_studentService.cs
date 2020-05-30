using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_tool_student
{
    public class Program_enrollment_tool_studentService : SubServiceBase<ERPProgram_enrollment_tool_student>
    {
        public Program_enrollment_tool_studentService(ERPNextClient client)
            : base(DocType.Program_enrollment_tool_student, client) { }

        protected override ERPProgram_enrollment_tool_student fromERPObject(ERPObject obj)
        {
            return new ERPProgram_enrollment_tool_student(obj);
        }
    }
}