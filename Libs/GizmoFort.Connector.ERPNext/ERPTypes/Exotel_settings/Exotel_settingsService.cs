using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Exotel_settings
{
    public class Exotel_settingsService : SubServiceBase<ERPExotel_settings>
    {
        public Exotel_settingsService(ERPNextClient client)
            : base(DocType.Exotel_settings, client) { }

        protected override ERPExotel_settings fromERPObject(ERPObject obj)
        {
            return new ERPExotel_settings(obj);
        }
    }
}