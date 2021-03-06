using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_type
{
    public class Hotel_room_typeService : SubServiceBase<ERPHotel_room_type>
    {
        public Hotel_room_typeService(ERPNextClient client)
            : base(DocType.Hotel_room_type, client) { }

        protected override ERPHotel_room_type fromERPObject(ERPObject obj)
        {
            return new ERPHotel_room_type(obj);
        }
    }
}