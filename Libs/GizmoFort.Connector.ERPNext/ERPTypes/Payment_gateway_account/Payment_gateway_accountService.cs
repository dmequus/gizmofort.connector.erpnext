using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_gateway_account
{
    public class Payment_gateway_accountService : SubServiceBase<ERPPayment_gateway_account>
    {
        public Payment_gateway_accountService(ERPNextClient client)
            : base(DocType.Payment_gateway_account, client) { }

        protected override ERPPayment_gateway_account fromERPObject(ERPObject obj)
        {
            return new ERPPayment_gateway_account(obj);
        }
    }
}