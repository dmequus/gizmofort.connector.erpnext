using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Discounted_invoice
{
    public class Discounted_invoiceService : SubServiceBase<ERPDiscounted_invoice>
    {
        public Discounted_invoiceService(ERPNextClient client)
            : base(DocType.Discounted_invoice, client) { }

        protected override ERPDiscounted_invoice fromERPObject(ERPObject obj)
        {
            return new ERPDiscounted_invoice(obj);
        }
    }
}