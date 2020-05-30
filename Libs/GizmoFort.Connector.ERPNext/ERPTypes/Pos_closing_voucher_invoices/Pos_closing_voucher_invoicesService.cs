using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher_invoices
{
    public class Pos_closing_voucher_invoicesService : SubServiceBase<ERPPos_closing_voucher_invoices>
    {
        public Pos_closing_voucher_invoicesService(ERPNextClient client)
            : base(DocType.Pos_closing_voucher_invoices, client) { }

        protected override ERPPos_closing_voucher_invoices fromERPObject(ERPObject obj)
        {
            return new ERPPos_closing_voucher_invoices(obj);
        }
    }
}