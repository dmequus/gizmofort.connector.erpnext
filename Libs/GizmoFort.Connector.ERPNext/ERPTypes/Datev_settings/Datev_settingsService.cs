using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Datev_settings
{
    public class Datev_settingsService : SubServiceBase<ERPDatev_settings>
    {
        public Datev_settingsService(ERPNextClient client)
            : base(DocType.Datev_settings, client) { }

        protected override ERPDatev_settings fromERPObject(ERPObject obj)
        {
            return new ERPDatev_settings(obj);
        }
    }
}