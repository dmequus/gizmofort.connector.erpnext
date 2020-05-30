using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Period_closing_voucher
{
    public class Period_closing_voucherService : SubServiceBase<ERPPeriod_closing_voucher>
    {
        public Period_closing_voucherService(ERPNextClient client)
            : base(DocType.Period_closing_voucher, client) { }

        protected override ERPPeriod_closing_voucher fromERPObject(ERPObject obj)
        {
            return new ERPPeriod_closing_voucher(obj);
        }
    }
}