using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_content
{
    public class Course_contentService : SubServiceBase<ERPCourse_content>
    {
        public Course_contentService(ERPNextClient client)
            : base(DocType.Course_content, client) { }

        protected override ERPCourse_content fromERPObject(ERPObject obj)
        {
            return new ERPCourse_content(obj);
        }
    }
}