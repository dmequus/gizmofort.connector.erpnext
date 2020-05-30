using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Selling_settings
{
    public class Selling_settingsService : SubServiceBase<ERPSelling_settings>
    {
        public Selling_settingsService(ERPNextClient client)
            : base(DocType.Selling_settings, client) { }

        protected override ERPSelling_settings fromERPObject(ERPObject obj)
        {
            return new ERPSelling_settings(obj);
        }
    }
}