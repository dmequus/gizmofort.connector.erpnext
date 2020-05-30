using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_entry
{
    public class Bank_statement_transaction_entryService : SubServiceBase<ERPBank_statement_transaction_entry>
    {
        public Bank_statement_transaction_entryService(ERPNextClient client)
            : base(DocType.Bank_statement_transaction_entry, client) { }

        protected override ERPBank_statement_transaction_entry fromERPObject(ERPObject obj)
        {
            return new ERPBank_statement_transaction_entry(obj);
        }
    }
}