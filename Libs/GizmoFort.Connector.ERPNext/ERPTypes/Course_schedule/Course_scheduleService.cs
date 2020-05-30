using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_schedule
{
    public class Course_scheduleService : SubServiceBase<ERPCourse_schedule>
    {
        public Course_scheduleService(ERPNextClient client)
            : base(DocType.Course_schedule, client) { }

        protected override ERPCourse_schedule fromERPObject(ERPObject obj)
        {
            return new ERPCourse_schedule(obj);
        }
    }
}