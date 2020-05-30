using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_enrollment
{
    public class Course_enrollmentService : SubServiceBase<ERPCourse_enrollment>
    {
        public Course_enrollmentService(ERPNextClient client)
            : base(DocType.Course_enrollment, client) { }

        protected override ERPCourse_enrollment fromERPObject(ERPObject obj)
        {
            return new ERPCourse_enrollment(obj);
        }
    }
}