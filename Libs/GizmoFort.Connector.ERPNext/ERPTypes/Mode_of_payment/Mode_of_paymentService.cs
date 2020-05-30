using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Mode_of_payment
{
    public class Mode_of_paymentService : SubServiceBase<ERPMode_of_payment>
    {
        public Mode_of_paymentService(ERPNextClient client)
            : base(DocType.Mode_of_payment, client) { }

        protected override ERPMode_of_payment fromERPObject(ERPObject obj)
        {
            return new ERPMode_of_payment(obj);
        }
    }
}