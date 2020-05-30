using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_payment
{
    public class Sales_invoice_paymentService : SubServiceBase<ERPSales_invoice_payment>
    {
        public Sales_invoice_paymentService(ERPNextClient client)
            : base(DocType.Sales_invoice_payment, client) { }

        protected override ERPSales_invoice_payment fromERPObject(ERPObject obj)
        {
            return new ERPSales_invoice_payment(obj);
        }
    }
}