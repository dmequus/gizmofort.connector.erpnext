using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_settings
{
    public class Delivery_settingsService : SubServiceBase<ERPDelivery_settings>
    {
        public Delivery_settingsService(ERPNextClient client)
            : base(DocType.Delivery_settings, client) { }

        protected override ERPDelivery_settings fromERPObject(ERPObject obj)
        {
            return new ERPDelivery_settings(obj);
        }
    }
}