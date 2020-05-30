using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_pricing
{
    public class Hotel_room_pricingService : SubServiceBase<ERPHotel_room_pricing>
    {
        public Hotel_room_pricingService(ERPNextClient client)
            : base(DocType.Hotel_room_pricing, client) { }

        protected override ERPHotel_room_pricing fromERPObject(ERPObject obj)
        {
            return new ERPHotel_room_pricing(obj);
        }
    }
}