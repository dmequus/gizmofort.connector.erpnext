using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_report_generation_tool
{
    public class Student_report_generation_toolService : SubServiceBase<ERPStudent_report_generation_tool>
    {
        public Student_report_generation_toolService(ERPNextClient client)
            : base(DocType.Student_report_generation_tool, client) { }

        protected override ERPStudent_report_generation_tool fromERPObject(ERPObject obj)
        {
            return new ERPStudent_report_generation_tool(obj);
        }
    }
}