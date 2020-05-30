using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_voucher
{
    public class Landed_cost_voucherService : SubServiceBase<ERPLanded_cost_voucher>
    {
        public Landed_cost_voucherService(ERPNextClient client)
            : base(DocType.Landed_cost_voucher, client) { }

        protected override ERPLanded_cost_voucher fromERPObject(ERPObject obj)
        {
            return new ERPLanded_cost_voucher(obj);
        }
    }
}