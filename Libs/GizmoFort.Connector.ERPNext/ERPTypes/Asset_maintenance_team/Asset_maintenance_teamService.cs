using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance_team
{
    public class Asset_maintenance_teamService : SubServiceBase<ERPAsset_maintenance_team>
    {
        public Asset_maintenance_teamService(ERPNextClient client)
            : base(DocType.Asset_maintenance_team, client) { }

        protected override ERPAsset_maintenance_team fromERPObject(ERPObject obj)
        {
            return new ERPAsset_maintenance_team(obj);
        }
    }
}