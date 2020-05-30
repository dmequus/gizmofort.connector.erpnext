using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance
{
    public class Asset_maintenanceService : SubServiceBase<ERPAsset_maintenance>
    {
        public Asset_maintenanceService(ERPNextClient client)
            : base(DocType.Asset_maintenance, client) { }

        protected override ERPAsset_maintenance fromERPObject(ERPObject obj)
        {
            return new ERPAsset_maintenance(obj);
        }
    }
}