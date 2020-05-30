using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan
{
    public class LoanService : SubServiceBase<ERPLoan>
    {
        public LoanService(ERPNextClient client)
            : base(DocType.Loan, client) { }

        protected override ERPLoan fromERPObject(ERPObject obj)
        {
            return new ERPLoan(obj);
        }
    }
}