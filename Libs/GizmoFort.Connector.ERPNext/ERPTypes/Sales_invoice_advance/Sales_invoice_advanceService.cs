using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_advance
{
    public class Sales_invoice_advanceService : SubServiceBase<ERPSales_invoice_advance>
    {
        public Sales_invoice_advanceService(ERPNextClient client)
            : base(DocType.Sales_invoice_advance, client) { }

        protected override ERPSales_invoice_advance fromERPObject(ERPObject obj)
        {
            return new ERPSales_invoice_advance(obj);
        }
    }
}