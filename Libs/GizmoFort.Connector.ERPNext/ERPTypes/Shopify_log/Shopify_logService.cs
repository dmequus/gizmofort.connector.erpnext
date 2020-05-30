using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_log
{
    public class Shopify_logService : SubServiceBase<ERPShopify_log>
    {
        public Shopify_logService(ERPNextClient client)
            : base(DocType.Shopify_log, client) { }

        protected override ERPShopify_log fromERPObject(ERPObject obj)
        {
            return new ERPShopify_log(obj);
        }
    }
}