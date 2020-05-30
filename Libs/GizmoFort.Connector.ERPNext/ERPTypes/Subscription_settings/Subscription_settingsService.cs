using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription_settings
{
    public class Subscription_settingsService : SubServiceBase<ERPSubscription_settings>
    {
        public Subscription_settingsService(ERPNextClient client)
            : base(DocType.Subscription_settings, client) { }

        protected override ERPSubscription_settings fromERPObject(ERPObject obj)
        {
            return new ERPSubscription_settings(obj);
        }
    }
}