using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopping_cart_settings
{
    public class Shopping_cart_settingsService : SubServiceBase<ERPShopping_cart_settings>
    {
        public Shopping_cart_settingsService(ERPNextClient client)
            : base(DocType.Shopping_cart_settings, client) { }

        protected override ERPShopping_cart_settings fromERPObject(ERPObject obj)
        {
            return new ERPShopping_cart_settings(obj);
        }
    }
}