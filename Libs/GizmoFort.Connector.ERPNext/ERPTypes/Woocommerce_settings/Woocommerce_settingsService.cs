using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Woocommerce_settings
{
    public class Woocommerce_settingsService : SubServiceBase<ERPWoocommerce_settings>
    {
        public Woocommerce_settingsService(ERPNextClient client)
            : base(DocType.Woocommerce_settings, client) { }

        protected override ERPWoocommerce_settings fromERPObject(ERPObject obj)
        {
            return new ERPWoocommerce_settings(obj);
        }
    }
}