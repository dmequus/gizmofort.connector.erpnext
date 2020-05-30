using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim
{
    public class Expense_claimService : SubServiceBase<ERPExpense_claim>
    {
        public Expense_claimService(ERPNextClient client)
            : base(DocType.Expense_claim, client) { }

        protected override ERPExpense_claim fromERPObject(ERPObject obj)
        {
            return new ERPExpense_claim(obj);
        }
    }
}