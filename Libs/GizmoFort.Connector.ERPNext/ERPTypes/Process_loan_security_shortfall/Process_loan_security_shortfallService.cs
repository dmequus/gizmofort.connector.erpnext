using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Process_loan_security_shortfall
{
    public class Process_loan_security_shortfallService : SubServiceBase<ERPProcess_loan_security_shortfall>
    {
        public Process_loan_security_shortfallService(ERPNextClient client)
            : base(DocType.Process_loan_security_shortfall, client) { }

        protected override ERPProcess_loan_security_shortfall fromERPObject(ERPObject obj)
        {
            return new ERPProcess_loan_security_shortfall(obj);
        }
    }
}