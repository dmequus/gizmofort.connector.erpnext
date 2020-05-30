using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_reservation_item
{
    public class Hotel_room_reservation_itemService : SubServiceBase<ERPHotel_room_reservation_item>
    {
        public Hotel_room_reservation_itemService(ERPNextClient client)
            : base(DocType.Hotel_room_reservation_item, client) { }

        protected override ERPHotel_room_reservation_item fromERPObject(ERPObject obj)
        {
            return new ERPHotel_room_reservation_item(obj);
        }
    }
}