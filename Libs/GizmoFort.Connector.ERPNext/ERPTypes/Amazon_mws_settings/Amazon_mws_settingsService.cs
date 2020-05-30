using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Amazon_mws_settings
{
    public class Amazon_mws_settingsService : SubServiceBase<ERPAmazon_mws_settings>
    {
        public Amazon_mws_settingsService(ERPNextClient client)
            : base(DocType.Amazon_mws_settings, client) { }

        protected override ERPAmazon_mws_settings fromERPObject(ERPObject obj)
        {
            return new ERPAmazon_mws_settings(obj);
        }
    }
}