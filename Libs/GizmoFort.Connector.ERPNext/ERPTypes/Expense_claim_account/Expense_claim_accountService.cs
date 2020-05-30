using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_account
{
    public class Expense_claim_accountService : SubServiceBase<ERPExpense_claim_account>
    {
        public Expense_claim_accountService(ERPNextClient client)
            : base(DocType.Expense_claim_account, client) { }

        protected override ERPExpense_claim_account fromERPObject(ERPObject obj)
        {
            return new ERPExpense_claim_account(obj);
        }
    }
}