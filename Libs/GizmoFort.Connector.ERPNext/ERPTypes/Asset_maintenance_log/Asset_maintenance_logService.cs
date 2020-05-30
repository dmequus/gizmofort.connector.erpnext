using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance_log
{
    public class Asset_maintenance_logService : SubServiceBase<ERPAsset_maintenance_log>
    {
        public Asset_maintenance_logService(ERPNextClient client)
            : base(DocType.Asset_maintenance_log, client) { }

        protected override ERPAsset_maintenance_log fromERPObject(ERPObject obj)
        {
            return new ERPAsset_maintenance_log(obj);
        }
    }
}