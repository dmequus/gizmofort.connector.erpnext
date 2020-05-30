using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription_invoice
{
    public class Subscription_invoiceService : SubServiceBase<ERPSubscription_invoice>
    {
        public Subscription_invoiceService(ERPNextClient client)
            : base(DocType.Subscription_invoice, client) { }

        protected override ERPSubscription_invoice fromERPObject(ERPObject obj)
        {
            return new ERPSubscription_invoice(obj);
        }
    }
}