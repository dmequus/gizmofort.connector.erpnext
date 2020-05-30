using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_disbursement
{
    public class Loan_disbursementService : SubServiceBase<ERPLoan_disbursement>
    {
        public Loan_disbursementService(ERPNextClient client)
            : base(DocType.Loan_disbursement, client) { }

        protected override ERPLoan_disbursement fromERPObject(ERPObject obj)
        {
            return new ERPLoan_disbursement(obj);
        }
    }
}