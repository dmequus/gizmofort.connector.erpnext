using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Plaid_settings
{
    public class Plaid_settingsService : SubServiceBase<ERPPlaid_settings>
    {
        public Plaid_settingsService(ERPNextClient client)
            : base(DocType.Plaid_settings, client) { }

        protected override ERPPlaid_settings fromERPObject(ERPObject obj)
        {
            return new ERPPlaid_settings(obj);
        }
    }
}