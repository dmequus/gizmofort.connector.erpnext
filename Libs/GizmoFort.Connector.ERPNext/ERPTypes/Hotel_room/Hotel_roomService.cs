using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room
{
    public class Hotel_roomService : SubServiceBase<ERPHotel_room>
    {
        public Hotel_roomService(ERPNextClient client)
            : base(DocType.Hotel_room, client) { }

        protected override ERPHotel_room fromERPObject(ERPObject obj)
        {
            return new ERPHotel_room(obj);
        }
    }
}