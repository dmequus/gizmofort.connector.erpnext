using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Budget
{
    public class BudgetService : SubServiceBase<ERPBudget>
    {
        public BudgetService(ERPNextClient client)
            : base(DocType.Budget, client) { }

        protected override ERPBudget fromERPObject(ERPObject obj)
        {
            return new ERPBudget(obj);
        }
    }
}