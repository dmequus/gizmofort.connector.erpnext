using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_invoice_item
{
    public class Purchase_invoice_itemService : SubServiceBase<ERPPurchase_invoice_item>
    {
        public Purchase_invoice_itemService(ERPNextClient client)
            : base(DocType.Purchase_invoice_item, client) { }

        protected override ERPPurchase_invoice_item fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_invoice_item(obj);
        }
    }
}