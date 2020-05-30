using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_leave_application
{
    public class Student_leave_applicationService : SubServiceBase<ERPStudent_leave_application>
    {
        public Student_leave_applicationService(ERPNextClient client)
            : base(DocType.Student_leave_application, client) { }

        protected override ERPStudent_leave_application fromERPObject(ERPObject obj)
        {
            return new ERPStudent_leave_application(obj);
        }
    }
}