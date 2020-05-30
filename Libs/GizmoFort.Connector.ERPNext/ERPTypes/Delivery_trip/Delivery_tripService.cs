using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_trip
{
    public class Delivery_tripService : SubServiceBase<ERPDelivery_trip>
    {
        public Delivery_tripService(ERPNextClient client)
            : base(DocType.Delivery_trip, client) { }

        protected override ERPDelivery_trip fromERPObject(ERPObject obj)
        {
            return new ERPDelivery_trip(obj);
        }
    }
}