using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_invoice
{
    public class Purchase_invoiceService : SubServiceBase<ERPPurchase_invoice>
    {
        public Purchase_invoiceService(ERPNextClient client)
            : base(DocType.Purchase_invoice, client) { }

        protected override ERPPurchase_invoice fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_invoice(obj);
        }
    }
}