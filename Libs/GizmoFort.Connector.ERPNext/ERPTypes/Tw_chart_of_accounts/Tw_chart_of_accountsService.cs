using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Tw_chart_of_accounts
{
    public class Tw_chart_of_accountsService : SubServiceBase<ERPTw_chart_of_accounts>
    {
        public Tw_chart_of_accountsService(ERPNextClient client)
            : base(DocType.Tw_chart_of_accounts, client) { }

        protected override ERPTw_chart_of_accounts fromERPObject(ERPObject obj)
        {
            return new ERPTw_chart_of_accounts(obj);
        }
    }
}