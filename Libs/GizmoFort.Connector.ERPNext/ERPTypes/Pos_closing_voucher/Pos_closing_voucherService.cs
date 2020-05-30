using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher
{
    public class Pos_closing_voucherService : SubServiceBase<ERPPos_closing_voucher>
    {
        public Pos_closing_voucherService(ERPNextClient client)
            : base(DocType.Pos_closing_voucher, client) { }

        protected override ERPPos_closing_voucher fromERPObject(ERPObject obj)
        {
            return new ERPPos_closing_voucher(obj);
        }
    }
}