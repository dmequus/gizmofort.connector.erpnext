using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_tool
{
    public class Program_enrollment_toolService : SubServiceBase<ERPProgram_enrollment_tool>
    {
        public Program_enrollment_toolService(ERPNextClient client)
            : base(DocType.Program_enrollment_tool, client) { }

        protected override ERPProgram_enrollment_tool fromERPObject(ERPObject obj)
        {
            return new ERPProgram_enrollment_tool(obj);
        }
    }
}