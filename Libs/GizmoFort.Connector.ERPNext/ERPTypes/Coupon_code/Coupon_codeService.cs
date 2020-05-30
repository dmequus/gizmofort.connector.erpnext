using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Coupon_code
{
    public class Coupon_codeService : SubServiceBase<ERPCoupon_code>
    {
        public Coupon_codeService(ERPNextClient client)
            : base(DocType.Coupon_code, client) { }

        protected override ERPCoupon_code fromERPObject(ERPObject obj)
        {
            return new ERPCoupon_code(obj);
        }
    }
}