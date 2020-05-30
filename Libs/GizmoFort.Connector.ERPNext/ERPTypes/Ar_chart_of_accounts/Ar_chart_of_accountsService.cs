using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ar_chart_of_accounts
{
    public class Ar_chart_of_accountsService : SubServiceBase<ERPAr_chart_of_accounts>
    {
        public Ar_chart_of_accountsService(ERPNextClient client)
            : base(DocType.Ar_chart_of_accounts, client) { }

        protected override ERPAr_chart_of_accounts fromERPObject(ERPObject obj)
        {
            return new ERPAr_chart_of_accounts(obj);
        }
    }
}