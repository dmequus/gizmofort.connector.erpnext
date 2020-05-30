using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Guardian_student
{
    public class Guardian_studentService : SubServiceBase<ERPGuardian_student>
    {
        public Guardian_studentService(ERPNextClient client)
            : base(DocType.Guardian_student, client) { }

        protected override ERPGuardian_student fromERPObject(ERPObject obj)
        {
            return new ERPGuardian_student(obj);
        }
    }
}