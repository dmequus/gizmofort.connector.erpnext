using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Gst_settings
{
    public class Gst_settingsService : SubServiceBase<ERPGst_settings>
    {
        public Gst_settingsService(ERPNextClient client)
            : base(DocType.Gst_settings, client) { }

        protected override ERPGst_settings fromERPObject(ERPObject obj)
        {
            return new ERPGst_settings(obj);
        }
    }
}