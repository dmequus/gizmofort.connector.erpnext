using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_course
{
    public class Program_enrollment_courseService : SubServiceBase<ERPProgram_enrollment_course>
    {
        public Program_enrollment_courseService(ERPNextClient client)
            : base(DocType.Program_enrollment_course, client) { }

        protected override ERPProgram_enrollment_course fromERPObject(ERPObject obj)
        {
            return new ERPProgram_enrollment_course(obj);
        }
    }
}