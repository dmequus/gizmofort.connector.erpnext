using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_admission
{
    public class Student_admissionService : SubServiceBase<ERPStudent_admission>
    {
        public Student_admissionService(ERPNextClient client)
            : base(DocType.Student_admission, client) { }

        protected override ERPStudent_admission fromERPObject(ERPObject obj)
        {
            return new ERPStudent_admission(obj);
        }
    }
}