using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_webhook_detail
{
    public class Shopify_webhook_detailService : SubServiceBase<ERPShopify_webhook_detail>
    {
        public Shopify_webhook_detailService(ERPNextClient client)
            : base(DocType.Shopify_webhook_detail, client) { }

        protected override ERPShopify_webhook_detail fromERPObject(ERPObject obj)
        {
            return new ERPShopify_webhook_detail(obj);
        }
    }
}