using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Invoice_discounting
{
    public class Invoice_discountingService : SubServiceBase<ERPInvoice_discounting>
    {
        public Invoice_discountingService(ERPNextClient client)
            : base(DocType.Invoice_discounting, client) { }

        protected override ERPInvoice_discounting fromERPObject(ERPObject obj)
        {
            return new ERPInvoice_discounting(obj);
        }
    }
}