using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_transaction_payments
{
    public class Bank_transaction_paymentsService : SubServiceBase<ERPBank_transaction_payments>
    {
        public Bank_transaction_paymentsService(ERPNextClient client)
            : base(DocType.Bank_transaction_payments, client) { }

        protected override ERPBank_transaction_payments fromERPObject(ERPObject obj)
        {
            return new ERPBank_transaction_payments(obj);
        }
    }
}