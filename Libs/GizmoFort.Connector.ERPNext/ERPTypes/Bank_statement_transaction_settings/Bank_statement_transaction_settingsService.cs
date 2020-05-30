using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_settings
{
    public class Bank_statement_transaction_settingsService : SubServiceBase<ERPBank_statement_transaction_settings>
    {
        public Bank_statement_transaction_settingsService(ERPNextClient client)
            : base(DocType.Bank_statement_transaction_settings, client) { }

        protected override ERPBank_statement_transaction_settings fromERPObject(ERPObject obj)
        {
            return new ERPBank_statement_transaction_settings(obj);
        }
    }
}