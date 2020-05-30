using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_request
{
    public class Payment_requestService : SubServiceBase<ERPPayment_request>
    {
        public Payment_requestService(ERPNextClient client)
            : base(DocType.Payment_request, client) { }

        protected override ERPPayment_request fromERPObject(ERPObject obj)
        {
            return new ERPPayment_request(obj);
        }
    }
}