using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_movement_item
{
    public class Asset_movement_itemService : SubServiceBase<ERPAsset_movement_item>
    {
        public Asset_movement_itemService(ERPNextClient client)
            : base(DocType.Asset_movement_item, client) { }

        protected override ERPAsset_movement_item fromERPObject(ERPObject obj)
        {
            return new ERPAsset_movement_item(obj);
        }
    }
}