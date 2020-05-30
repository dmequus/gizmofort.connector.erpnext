using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_payment_item
{
    public class Bank_statement_transaction_payment_itemService : SubServiceBase<ERPBank_statement_transaction_payment_item>
    {
        public Bank_statement_transaction_payment_itemService(ERPNextClient client)
            : base(DocType.Bank_statement_transaction_payment_item, client) { }

        protected override ERPBank_statement_transaction_payment_item fromERPObject(ERPObject obj)
        {
            return new ERPBank_statement_transaction_payment_item(obj);
        }
    }
}