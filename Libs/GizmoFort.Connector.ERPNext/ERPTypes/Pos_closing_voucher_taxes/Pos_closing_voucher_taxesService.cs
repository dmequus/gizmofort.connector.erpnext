using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher_taxes
{
    public class Pos_closing_voucher_taxesService : SubServiceBase<ERPPos_closing_voucher_taxes>
    {
        public Pos_closing_voucher_taxesService(ERPNextClient client)
            : base(DocType.Pos_closing_voucher_taxes, client) { }

        protected override ERPPos_closing_voucher_taxes fromERPObject(ERPObject obj)
        {
            return new ERPPos_closing_voucher_taxes(obj);
        }
    }
}