using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_invoice_advance
{
    public class Purchase_invoice_advanceService : SubServiceBase<ERPPurchase_invoice_advance>
    {
        public Purchase_invoice_advanceService(ERPNextClient client)
            : base(DocType.Purchase_invoice_advance, client) { }

        protected override ERPPurchase_invoice_advance fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_invoice_advance(obj);
        }
    }
}