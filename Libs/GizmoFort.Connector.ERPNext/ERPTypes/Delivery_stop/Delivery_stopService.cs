using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_stop
{
    public class Delivery_stopService : SubServiceBase<ERPDelivery_stop>
    {
        public Delivery_stopService(ERPNextClient client)
            : base(DocType.Delivery_stop, client) { }

        protected override ERPDelivery_stop fromERPObject(ERPObject obj)
        {
            return new ERPDelivery_stop(obj);
        }
    }
}