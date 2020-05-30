using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription
{
    public class SubscriptionService : SubServiceBase<ERPSubscription>
    {
        public SubscriptionService(ERPNextClient client)
            : base(DocType.Subscription, client) { }

        protected override ERPSubscription fromERPObject(ERPObject obj)
        {
            return new ERPSubscription(obj);
        }
    }
}