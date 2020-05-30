using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_movement
{
    public class Asset_movementService : SubServiceBase<ERPAsset_movement>
    {
        public Asset_movementService(ERPNextClient client)
            : base(DocType.Asset_movement, client) { }

        protected override ERPAsset_movement fromERPObject(ERPObject obj)
        {
            return new ERPAsset_movement(obj);
        }
    }
}