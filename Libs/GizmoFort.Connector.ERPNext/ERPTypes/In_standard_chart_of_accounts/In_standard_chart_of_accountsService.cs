using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.In_standard_chart_of_accounts
{
    public class In_standard_chart_of_accountsService : SubServiceBase<ERPIn_standard_chart_of_accounts>
    {
        public In_standard_chart_of_accountsService(ERPNextClient client)
            : base(DocType.In_standard_chart_of_accounts, client) { }

        protected override ERPIn_standard_chart_of_accounts fromERPObject(ERPObject obj)
        {
            return new ERPIn_standard_chart_of_accounts(obj);
        }
    }
}