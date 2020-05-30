using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription_plan
{
    public class Subscription_planService : SubServiceBase<ERPSubscription_plan>
    {
        public Subscription_planService(ERPNextClient client)
            : base(DocType.Subscription_plan, client) { }

        protected override ERPSubscription_plan fromERPObject(ERPObject obj)
        {
            return new ERPSubscription_plan(obj);
        }
    }
}