using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security
{
    public class Loan_securityService : SubServiceBase<ERPLoan_security>
    {
        public Loan_securityService(ERPNextClient client)
            : base(DocType.Loan_security, client) { }

        protected override ERPLoan_security fromERPObject(ERPObject obj)
        {
            return new ERPLoan_security(obj);
        }
    }
}