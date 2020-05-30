using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Twitter_settings
{
    public class Twitter_settingsService : SubServiceBase<ERPTwitter_settings>
    {
        public Twitter_settingsService(ERPNextClient client)
            : base(DocType.Twitter_settings, client) { }

        protected override ERPTwitter_settings fromERPObject(ERPObject obj)
        {
            return new ERPTwitter_settings(obj);
        }
    }
}