using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_repayment
{
    public class Loan_repaymentService : SubServiceBase<ERPLoan_repayment>
    {
        public Loan_repaymentService(ERPNextClient client)
            : base(DocType.Loan_repayment, client) { }

        protected override ERPLoan_repayment fromERPObject(ERPObject obj)
        {
            return new ERPLoan_repayment(obj);
        }
    }
}