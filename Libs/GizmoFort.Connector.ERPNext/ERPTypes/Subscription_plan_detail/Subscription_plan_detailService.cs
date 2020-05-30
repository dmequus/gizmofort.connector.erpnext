using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription_plan_detail
{
    public class Subscription_plan_detailService : SubServiceBase<ERPSubscription_plan_detail>
    {
        public Subscription_plan_detailService(ERPNextClient client)
            : base(DocType.Subscription_plan_detail, client) { }

        protected override ERPSubscription_plan_detail fromERPObject(ERPObject obj)
        {
            return new ERPSubscription_plan_detail(obj);
        }
    }
}