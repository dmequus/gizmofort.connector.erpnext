using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_order_reference
{
    public class Payment_order_referenceService : SubServiceBase<ERPPayment_order_reference>
    {
        public Payment_order_referenceService(ERPNextClient client)
            : base(DocType.Payment_order_reference, client) { }

        protected override ERPPayment_order_reference fromERPObject(ERPObject obj)
        {
            return new ERPPayment_order_reference(obj);
        }
    }
}