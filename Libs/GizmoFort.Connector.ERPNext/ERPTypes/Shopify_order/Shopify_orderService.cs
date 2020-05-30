using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_order
{
    public class Shopify_orderService : SubServiceBase<ERPShopify_order>
    {
        public Shopify_orderService(ERPNextClient client)
            : base(DocType.Shopify_order, client) { }

        protected override ERPShopify_order fromERPObject(ERPObject obj)
        {
            return new ERPShopify_order(obj);
        }
    }
}