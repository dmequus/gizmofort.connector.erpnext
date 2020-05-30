using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_category
{
    public class Asset_categoryService : SubServiceBase<ERPAsset_category>
    {
        public Asset_categoryService(ERPNextClient client)
            : base(DocType.Asset_category, client) { }

        protected override ERPAsset_category fromERPObject(ERPObject obj)
        {
            return new ERPAsset_category(obj);
        }
    }
}