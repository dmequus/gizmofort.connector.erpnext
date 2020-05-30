using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Instructor
{
    public class InstructorService : SubServiceBase<ERPInstructor>
    {
        public InstructorService(ERPNextClient client)
            : base(DocType.Instructor, client) { }

        protected override ERPInstructor fromERPObject(ERPObject obj)
        {
            return new ERPInstructor(obj);
        }
    }
}