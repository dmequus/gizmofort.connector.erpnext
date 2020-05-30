using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Process_loan_interest_accrual
{
    public class Process_loan_interest_accrualService : SubServiceBase<ERPProcess_loan_interest_accrual>
    {
        public Process_loan_interest_accrualService(ERPNextClient client)
            : base(DocType.Process_loan_interest_accrual, client) { }

        protected override ERPProcess_loan_interest_accrual fromERPObject(ERPObject obj)
        {
            return new ERPProcess_loan_interest_accrual(obj);
        }
    }
}