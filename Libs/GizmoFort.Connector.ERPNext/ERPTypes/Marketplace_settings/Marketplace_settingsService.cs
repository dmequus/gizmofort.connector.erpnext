using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Marketplace_settings
{
    public class Marketplace_settingsService : SubServiceBase<ERPMarketplace_settings>
    {
        public Marketplace_settingsService(ERPNextClient client)
            : base(DocType.Marketplace_settings, client) { }

        protected override ERPMarketplace_settings fromERPObject(ERPObject obj)
        {
            return new ERPMarketplace_settings(obj);
        }
    }
}