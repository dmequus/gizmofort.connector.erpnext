using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_fee
{
    public class Program_enrollment_feeService : SubServiceBase<ERPProgram_enrollment_fee>
    {
        public Program_enrollment_feeService(ERPNextClient client)
            : base(DocType.Program_enrollment_fee, client) { }

        protected override ERPProgram_enrollment_fee fromERPObject(ERPObject obj)
        {
            return new ERPProgram_enrollment_fee(obj);
        }
    }
}