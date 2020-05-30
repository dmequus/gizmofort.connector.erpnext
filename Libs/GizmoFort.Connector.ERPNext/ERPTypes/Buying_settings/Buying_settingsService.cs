using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying_settings
{
    public class Buying_settingsService : SubServiceBase<ERPBuying_settings>
    {
        public Buying_settingsService(ERPNextClient client)
            : base(DocType.Buying_settings, client) { }

        protected override ERPBuying_settings fromERPObject(ERPObject obj)
        {
            return new ERPBuying_settings(obj);
        }
    }
}