using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_transaction
{
    public class Bank_transactionService : SubServiceBase<ERPBank_transaction>
    {
        public Bank_transactionService(ERPNextClient client)
            : base(DocType.Bank_transaction, client) { }

        protected override ERPBank_transaction fromERPObject(ERPObject obj)
        {
            return new ERPBank_transaction(obj);
        }
    }
}