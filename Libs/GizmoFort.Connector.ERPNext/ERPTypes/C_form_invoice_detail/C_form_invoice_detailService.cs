using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.C_form_invoice_detail
{
    public class C_form_invoice_detailService : SubServiceBase<ERPC_form_invoice_detail>
    {
        public C_form_invoice_detailService(ERPNextClient client)
            : base(DocType.C_form_invoice_detail, client) { }

        protected override ERPC_form_invoice_detail fromERPObject(ERPObject obj)
        {
            return new ERPC_form_invoice_detail(obj);
        }
    }
}