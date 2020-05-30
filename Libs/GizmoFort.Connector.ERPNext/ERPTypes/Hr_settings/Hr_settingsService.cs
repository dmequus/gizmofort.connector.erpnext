using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hr_settings
{
    public class Hr_settingsService : SubServiceBase<ERPHr_settings>
    {
        public Hr_settingsService(ERPNextClient client)
            : base(DocType.Hr_settings, client) { }

        protected override ERPHr_settings fromERPObject(ERPObject obj)
        {
            return new ERPHr_settings(obj);
        }
    }
}