using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_amenity
{
    public class Hotel_room_amenityService : SubServiceBase<ERPHotel_room_amenity>
    {
        public Hotel_room_amenityService(ERPNextClient client)
            : base(DocType.Hotel_room_amenity, client) { }

        protected override ERPHotel_room_amenity fromERPObject(ERPObject obj)
        {
            return new ERPHotel_room_amenity(obj);
        }
    }
}