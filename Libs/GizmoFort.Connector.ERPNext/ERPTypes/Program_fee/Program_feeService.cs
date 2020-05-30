using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_fee
{
    public class Program_feeService : SubServiceBase<ERPProgram_fee>
    {
        public Program_feeService(ERPNextClient client)
            : base(DocType.Program_fee, client) { }

        protected override ERPProgram_fee fromERPObject(ERPObject obj)
        {
            return new ERPProgram_fee(obj);
        }
    }
}