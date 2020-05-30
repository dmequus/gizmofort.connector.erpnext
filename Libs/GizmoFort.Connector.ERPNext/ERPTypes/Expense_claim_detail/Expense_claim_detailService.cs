using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_detail
{
    public class Expense_claim_detailService : SubServiceBase<ERPExpense_claim_detail>
    {
        public Expense_claim_detailService(ERPNextClient client)
            : base(DocType.Expense_claim_detail, client) { }

        protected override ERPExpense_claim_detail fromERPObject(ERPObject obj)
        {
            return new ERPExpense_claim_detail(obj);
        }
    }
}