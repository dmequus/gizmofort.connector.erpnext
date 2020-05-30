using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_taxes_and_charges
{
    public class Expense_taxes_and_chargesService : SubServiceBase<ERPExpense_taxes_and_charges>
    {
        public Expense_taxes_and_chargesService(ERPNextClient client)
            : base(DocType.Expense_taxes_and_charges, client) { }

        protected override ERPExpense_taxes_and_charges fromERPObject(ERPObject obj)
        {
            return new ERPExpense_taxes_and_charges(obj);
        }
    }
}