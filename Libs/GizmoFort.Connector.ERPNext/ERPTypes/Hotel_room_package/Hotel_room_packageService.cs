using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_package
{
    public class Hotel_room_packageService : SubServiceBase<ERPHotel_room_package>
    {
        public Hotel_room_packageService(ERPNextClient client)
            : base(DocType.Hotel_room_package, client) { }

        protected override ERPHotel_room_package fromERPObject(ERPObject obj)
        {
            return new ERPHotel_room_package(obj);
        }
    }
}