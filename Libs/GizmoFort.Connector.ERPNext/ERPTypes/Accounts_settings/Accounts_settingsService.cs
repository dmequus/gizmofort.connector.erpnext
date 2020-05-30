using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts_settings
{
    public class Accounts_settingsService : SubServiceBase<ERPAccounts_settings>
    {
        public Accounts_settingsService(ERPNextClient client)
            : base(DocType.Accounts_settings, client) { }

        protected override ERPAccounts_settings fromERPObject(ERPObject obj)
        {
            return new ERPAccounts_settings(obj);
        }
    }
}