using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Course
{
    public class CourseService : SubServiceBase<ERPCourse>
    {
        public CourseService(ERPNextClient client)
            : base(DocType.Course, client) { }

        protected override ERPCourse fromERPObject(ERPObject obj)
        {
            return new ERPCourse(obj);
        }
    }
}