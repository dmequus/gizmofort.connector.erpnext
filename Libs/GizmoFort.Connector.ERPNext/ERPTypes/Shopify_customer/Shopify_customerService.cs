using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_customer
{
    public class Shopify_customerService : SubServiceBase<ERPShopify_customer>
    {
        public Shopify_customerService(ERPNextClient client)
            : base(DocType.Shopify_customer, client) { }

        protected override ERPShopify_customer fromERPObject(ERPObject obj)
        {
            return new ERPShopify_customer(obj);
        }
    }
}