using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_reservation
{
    public class Restaurant_reservationService : SubServiceBase<ERPRestaurant_reservation>
    {
        public Restaurant_reservationService(ERPNextClient client)
            : base(DocType.Restaurant_reservation, client) { }

        protected override ERPRestaurant_reservation fromERPObject(ERPObject obj)
        {
            return new ERPRestaurant_reservation(obj);
        }
    }
}