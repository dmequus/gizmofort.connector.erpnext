using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_unpledge
{
    public class Loan_security_unpledgeService : SubServiceBase<ERPLoan_security_unpledge>
    {
        public Loan_security_unpledgeService(ERPNextClient client)
            : base(DocType.Loan_security_unpledge, client) { }

        protected override ERPLoan_security_unpledge fromERPObject(ERPObject obj)
        {
            return new ERPLoan_security_unpledge(obj);
        }
    }
}