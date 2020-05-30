using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_activity
{
    public class Course_activityService : SubServiceBase<ERPCourse_activity>
    {
        public Course_activityService(ERPNextClient client)
            : base(DocType.Course_activity, client) { }

        protected override ERPCourse_activity fromERPObject(ERPObject obj)
        {
            return new ERPCourse_activity(obj);
        }
    }
}