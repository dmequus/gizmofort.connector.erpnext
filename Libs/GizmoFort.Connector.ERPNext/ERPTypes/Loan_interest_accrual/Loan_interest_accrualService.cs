using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_interest_accrual
{
    public class Loan_interest_accrualService : SubServiceBase<ERPLoan_interest_accrual>
    {
        public Loan_interest_accrualService(ERPNextClient client)
            : base(DocType.Loan_interest_accrual, client) { }

        protected override ERPLoan_interest_accrual fromERPObject(ERPObject obj)
        {
            return new ERPLoan_interest_accrual(obj);
        }
    }
}