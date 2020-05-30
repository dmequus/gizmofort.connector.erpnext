using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Mode_of_payment_account
{
    public class Mode_of_payment_accountService : SubServiceBase<ERPMode_of_payment_account>
    {
        public Mode_of_payment_accountService(ERPNextClient client)
            : base(DocType.Mode_of_payment_account, client) { }

        protected override ERPMode_of_payment_account fromERPObject(ERPObject obj)
        {
            return new ERPMode_of_payment_account(obj);
        }
    }
}