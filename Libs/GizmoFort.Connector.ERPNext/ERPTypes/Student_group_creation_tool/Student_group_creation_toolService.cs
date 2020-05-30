using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group_creation_tool
{
    public class Student_group_creation_toolService : SubServiceBase<ERPStudent_group_creation_tool>
    {
        public Student_group_creation_toolService(ERPNextClient client)
            : base(DocType.Student_group_creation_tool, client) { }

        protected override ERPStudent_group_creation_tool fromERPObject(ERPObject obj)
        {
            return new ERPStudent_group_creation_tool(obj);
        }
    }
}