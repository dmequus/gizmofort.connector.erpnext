using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Budget_account
{
    public class Budget_accountService : SubServiceBase<ERPBudget_account>
    {
        public Budget_accountService(ERPNextClient client)
            : base(DocType.Budget_account, client) { }

        protected override ERPBudget_account fromERPObject(ERPObject obj)
        {
            return new ERPBudget_account(obj);
        }
    }
}