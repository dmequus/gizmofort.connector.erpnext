using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Import_supplier_invoice
{
    public class Import_supplier_invoiceService : SubServiceBase<ERPImport_supplier_invoice>
    {
        public Import_supplier_invoiceService(ERPNextClient client)
            : base(DocType.Import_supplier_invoice, client) { }

        protected override ERPImport_supplier_invoice fromERPObject(ERPObject obj)
        {
            return new ERPImport_supplier_invoice(obj);
        }
    }
}