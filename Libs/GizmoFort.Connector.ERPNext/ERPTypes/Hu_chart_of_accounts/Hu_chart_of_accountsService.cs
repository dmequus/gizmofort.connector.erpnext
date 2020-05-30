using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hu_chart_of_accounts
{
    public class Hu_chart_of_accountsService : SubServiceBase<ERPHu_chart_of_accounts>
    {
        public Hu_chart_of_accountsService(ERPNextClient client)
            : base(DocType.Hu_chart_of_accounts, client) { }

        protected override ERPHu_chart_of_accounts fromERPObject(ERPObject obj)
        {
            return new ERPHu_chart_of_accounts(obj);
        }
    }
}