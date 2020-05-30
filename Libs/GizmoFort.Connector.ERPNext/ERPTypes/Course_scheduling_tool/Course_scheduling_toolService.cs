using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_scheduling_tool
{
    public class Course_scheduling_toolService : SubServiceBase<ERPCourse_scheduling_tool>
    {
        public Course_scheduling_toolService(ERPNextClient client)
            : base(DocType.Course_scheduling_tool, client) { }

        protected override ERPCourse_scheduling_tool fromERPObject(ERPObject obj)
        {
            return new ERPCourse_scheduling_tool(obj);
        }
    }
}