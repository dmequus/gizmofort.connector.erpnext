using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Instructor_log
{
    public class Instructor_logService : SubServiceBase<ERPInstructor_log>
    {
        public Instructor_logService(ERPNextClient client)
            : base(DocType.Instructor_log, client) { }

        protected override ERPInstructor_log fromERPObject(ERPObject obj)
        {
            return new ERPInstructor_log(obj);
        }
    }
}