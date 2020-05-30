using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_repayment_detail
{
    public class Loan_repayment_detailService : SubServiceBase<ERPLoan_repayment_detail>
    {
        public Loan_repayment_detailService(ERPNextClient client)
            : base(DocType.Loan_repayment_detail, client) { }

        protected override ERPLoan_repayment_detail fromERPObject(ERPObject obj)
        {
            return new ERPLoan_repayment_detail(obj);
        }
    }
}