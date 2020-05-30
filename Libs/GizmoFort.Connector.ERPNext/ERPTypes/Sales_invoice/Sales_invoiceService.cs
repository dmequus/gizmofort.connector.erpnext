using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice
{
    public class Sales_invoiceService : SubServiceBase<ERPSales_invoice>
    {
        public Sales_invoiceService(ERPNextClient client)
            : base(DocType.Sales_invoice, client) { }

        protected override ERPSales_invoice fromERPObject(ERPObject obj)
        {
            return new ERPSales_invoice(obj);
        }
    }
}