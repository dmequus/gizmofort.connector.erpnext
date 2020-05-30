using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_reconciliation_payment
{
    public class Payment_reconciliation_paymentService : SubServiceBase<ERPPayment_reconciliation_payment>
    {
        public Payment_reconciliation_paymentService(ERPNextClient client)
            : base(DocType.Payment_reconciliation_payment, client) { }

        protected override ERPPayment_reconciliation_payment fromERPObject(ERPObject obj)
        {
            return new ERPPayment_reconciliation_payment(obj);
        }
    }
}