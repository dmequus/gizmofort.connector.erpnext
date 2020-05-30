using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_tax_account
{
    public class Shopify_tax_accountService : SubServiceBase<ERPShopify_tax_account>
    {
        public Shopify_tax_accountService(ERPNextClient client)
            : base(DocType.Shopify_tax_account, client) { }

        protected override ERPShopify_tax_account fromERPObject(ERPObject obj)
        {
            return new ERPShopify_tax_account(obj);
        }
    }
}