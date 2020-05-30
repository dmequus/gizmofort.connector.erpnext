using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Products_settings
{
    public class Products_settingsService : SubServiceBase<ERPProducts_settings>
    {
        public Products_settingsService(ERPNextClient client)
            : base(DocType.Products_settings, client) { }

        protected override ERPProducts_settings fromERPObject(ERPObject obj)
        {
            return new ERPProducts_settings(obj);
        }
    }
}