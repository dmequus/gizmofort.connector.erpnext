using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment
{
    public class Program_enrollmentService : SubServiceBase<ERPProgram_enrollment>
    {
        public Program_enrollmentService(ERPNextClient client)
            : base(DocType.Program_enrollment, client) { }

        protected override ERPProgram_enrollment fromERPObject(ERPObject obj)
        {
            return new ERPProgram_enrollment(obj);
        }
    }
}