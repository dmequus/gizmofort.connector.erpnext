using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_order
{
    public class Payment_orderService : SubServiceBase<ERPPayment_order>
    {
        public Payment_orderService(ERPNextClient client)
            : base(DocType.Payment_order, client) { }

        protected override ERPPayment_order fromERPObject(ERPObject obj)
        {
            return new ERPPayment_order(obj);
        }
    }
}