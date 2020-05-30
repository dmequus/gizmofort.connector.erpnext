using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Id_chart_of_accounts
{
    public class Id_chart_of_accountsService : SubServiceBase<ERPId_chart_of_accounts>
    {
        public Id_chart_of_accountsService(ERPNextClient client)
            : base(DocType.Id_chart_of_accounts, client) { }

        protected override ERPId_chart_of_accounts fromERPObject(ERPObject obj)
        {
            return new ERPId_chart_of_accounts(obj);
        }
    }
}