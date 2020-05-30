using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_reservation
{
    public class Hotel_room_reservationService : SubServiceBase<ERPHotel_room_reservation>
    {
        public Hotel_room_reservationService(ERPNextClient client)
            : base(DocType.Hotel_room_reservation, client) { }

        protected override ERPHotel_room_reservation fromERPObject(ERPObject obj)
        {
            return new ERPHotel_room_reservation(obj);
        }
    }
}