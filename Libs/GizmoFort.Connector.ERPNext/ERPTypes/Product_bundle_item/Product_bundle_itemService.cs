using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Product_bundle_item
{
    public class Product_bundle_itemService : SubServiceBase<ERPProduct_bundle_item>
    {
        public Product_bundle_itemService(ERPNextClient client)
            : base(DocType.Product_bundle_item, client) { }

        protected override ERPProduct_bundle_item fromERPObject(ERPObject obj)
        {
            return new ERPProduct_bundle_item(obj);
        }
    }
}