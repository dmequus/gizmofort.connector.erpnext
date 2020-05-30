using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_course
{
    public class Program_courseService : SubServiceBase<ERPProgram_course>
    {
        public Program_courseService(ERPNextClient client)
            : base(DocType.Program_course, client) { }

        protected override ERPProgram_course fromERPObject(ERPObject obj)
        {
            return new ERPProgram_course(obj);
        }
    }
}