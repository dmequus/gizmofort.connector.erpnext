using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student
{
    public class StudentService : SubServiceBase<ERPStudent>
    {
        public StudentService(ERPNextClient client)
            : base(DocType.Student, client) { }

        protected override ERPStudent fromERPObject(ERPObject obj)
        {
            return new ERPStudent(obj);
        }
    }
}