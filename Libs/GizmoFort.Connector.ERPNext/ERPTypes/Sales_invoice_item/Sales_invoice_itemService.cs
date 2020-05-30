using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_item
{
    public class Sales_invoice_itemService : SubServiceBase<ERPSales_invoice_item>
    {
        public Sales_invoice_itemService(ERPNextClient client)
            : base(DocType.Sales_invoice_item, client) { }

        protected override ERPSales_invoice_item fromERPObject(ERPObject obj)
        {
            return new ERPSales_invoice_item(obj);
        }
    }
}