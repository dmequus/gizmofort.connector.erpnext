using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_reconciliation_invoice
{
    public class Payment_reconciliation_invoiceService : SubServiceBase<ERPPayment_reconciliation_invoice>
    {
        public Payment_reconciliation_invoiceService(ERPNextClient client)
            : base(DocType.Payment_reconciliation_invoice, client) { }

        protected override ERPPayment_reconciliation_invoice fromERPObject(ERPObject obj)
        {
            return new ERPPayment_reconciliation_invoice(obj);
        }
    }
}