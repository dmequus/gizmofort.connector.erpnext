using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_pledge
{
    public class Loan_security_pledgeService : SubServiceBase<ERPLoan_security_pledge>
    {
        public Loan_security_pledgeService(ERPNextClient client)
            : base(DocType.Loan_security_pledge, client) { }

        protected override ERPLoan_security_pledge fromERPObject(ERPObject obj)
        {
            return new ERPLoan_security_pledge(obj);
        }
    }
}