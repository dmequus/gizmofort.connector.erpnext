using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_repair
{
    public class Asset_repairService : SubServiceBase<ERPAsset_repair>
    {
        public Asset_repairService(ERPNextClient client)
            : base(DocType.Asset_repair, client) { }

        protected override ERPAsset_repair fromERPObject(ERPObject obj)
        {
            return new ERPAsset_repair(obj);
        }
    }
}