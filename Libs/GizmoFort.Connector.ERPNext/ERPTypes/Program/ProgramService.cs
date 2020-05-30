using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Program
{
    public class ProgramService : SubServiceBase<ERPProgram>
    {
        public ProgramService(ERPNextClient client)
            : base(DocType.Program, client) { }

        protected override ERPProgram fromERPObject(ERPObject obj)
        {
            return new ERPProgram(obj);
        }
    }
}