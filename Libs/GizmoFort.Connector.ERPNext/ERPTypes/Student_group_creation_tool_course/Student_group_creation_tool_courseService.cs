using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group_creation_tool_course
{
    public class Student_group_creation_tool_courseService : SubServiceBase<ERPStudent_group_creation_tool_course>
    {
        public Student_group_creation_tool_courseService(ERPNextClient client)
            : base(DocType.Student_group_creation_tool_course, client) { }

        protected override ERPStudent_group_creation_tool_course fromERPObject(ERPObject obj)
        {
            return new ERPStudent_group_creation_tool_course(obj);
        }
    }
}