using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_type
{
    public class Expense_claim_typeService : SubServiceBase<ERPExpense_claim_type>
    {
        public Expense_claim_typeService(ERPNextClient client)
            : base(DocType.Expense_claim_type, client) { }

        protected override ERPExpense_claim_type fromERPObject(ERPObject obj)
        {
            return new ERPExpense_claim_type(obj);
        }
    }
}