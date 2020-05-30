using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_settings
{
    public class Hotel_settingsService : SubServiceBase<ERPHotel_settings>
    {
        public Hotel_settingsService(ERPNextClient client)
            : base(DocType.Hotel_settings, client) { }

        protected override ERPHotel_settings fromERPObject(ERPObject obj)
        {
            return new ERPHotel_settings(obj);
        }
    }
}