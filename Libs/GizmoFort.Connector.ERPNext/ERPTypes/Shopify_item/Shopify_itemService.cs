using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_item
{
    public class Shopify_itemService : SubServiceBase<ERPShopify_item>
    {
        public Shopify_itemService(ERPNextClient client)
            : base(DocType.Shopify_item, client) { }

        protected override ERPShopify_item fromERPObject(ERPObject obj)
        {
            return new ERPShopify_item(obj);
        }
    }
}