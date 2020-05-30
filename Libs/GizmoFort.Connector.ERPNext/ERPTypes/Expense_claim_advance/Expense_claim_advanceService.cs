using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_advance
{
    public class Expense_claim_advanceService : SubServiceBase<ERPExpense_claim_advance>
    {
        public Expense_claim_advanceService(ERPNextClient client)
            : base(DocType.Expense_claim_advance, client) { }

        protected override ERPExpense_claim_advance fromERPObject(ERPObject obj)
        {
            return new ERPExpense_claim_advance(obj);
        }
    }
}