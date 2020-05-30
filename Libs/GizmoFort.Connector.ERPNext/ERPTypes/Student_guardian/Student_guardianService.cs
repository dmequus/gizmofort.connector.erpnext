using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_guardian
{
    public class Student_guardianService : SubServiceBase<ERPStudent_guardian>
    {
        public Student_guardianService(ERPNextClient client)
            : base(DocType.Student_guardian, client) { }

        protected override ERPStudent_guardian fromERPObject(ERPObject obj)
        {
            return new ERPStudent_guardian(obj);
        }
    }
}