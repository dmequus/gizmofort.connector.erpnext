using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_settings
{
    public class Shopify_settingsService : SubServiceBase<ERPShopify_settings>
    {
        public Shopify_settingsService(ERPNextClient client)
            : base(DocType.Shopify_settings, client) { }

        protected override ERPShopify_settings fromERPObject(ERPObject obj)
        {
            return new ERPShopify_settings(obj);
        }
    }
}