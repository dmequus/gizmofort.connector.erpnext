using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset
{
    public class AssetService : SubServiceBase<ERPAsset>
    {
        public AssetService(ERPNextClient client)
            : base(DocType.Asset, client) { }

        protected override ERPAsset fromERPObject(ERPObject obj)
        {
            return new ERPAsset(obj);
        }
    }
}