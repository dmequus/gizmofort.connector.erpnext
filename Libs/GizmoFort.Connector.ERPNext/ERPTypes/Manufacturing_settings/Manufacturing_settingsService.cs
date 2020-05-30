using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing_settings
{
    public class Manufacturing_settingsService : SubServiceBase<ERPManufacturing_settings>
    {
        public Manufacturing_settingsService(ERPNextClient client)
            : base(DocType.Manufacturing_settings, client) { }

        protected override ERPManufacturing_settings fromERPObject(ERPObject obj)
        {
            return new ERPManufacturing_settings(obj);
        }
    }
}