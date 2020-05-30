using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Support_settings
{
    public class Support_settingsService : SubServiceBase<ERPSupport_settings>
    {
        public Support_settingsService(ERPNextClient client)
            : base(DocType.Support_settings, client) { }

        protected override ERPSupport_settings fromERPObject(ERPObject obj)
        {
            return new ERPSupport_settings(obj);
        }
    }
}