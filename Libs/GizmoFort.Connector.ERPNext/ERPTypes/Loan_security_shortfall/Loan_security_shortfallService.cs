using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_shortfall
{
    public class Loan_security_shortfallService : SubServiceBase<ERPLoan_security_shortfall>
    {
        public Loan_security_shortfallService(ERPNextClient client)
            : base(DocType.Loan_security_shortfall, client) { }

        protected override ERPLoan_security_shortfall fromERPObject(ERPObject obj)
        {
            return new ERPLoan_security_shortfall(obj);
        }
    }
}