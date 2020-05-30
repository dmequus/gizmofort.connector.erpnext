using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Gocardless_settings
{
    public class Gocardless_settingsService : SubServiceBase<ERPGocardless_settings>
    {
        public Gocardless_settingsService(ERPNextClient client)
            : base(DocType.Gocardless_settings, client) { }

        protected override ERPGocardless_settings fromERPObject(ERPObject obj)
        {
            return new ERPGocardless_settings(obj);
        }
    }
}