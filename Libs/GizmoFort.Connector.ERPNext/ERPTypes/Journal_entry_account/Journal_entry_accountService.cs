using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry_account
{
    public class Journal_entry_accountService : SubServiceBase<ERPJournal_entry_account>
    {
        public Journal_entry_accountService(ERPNextClient client)
            : base(DocType.Journal_entry_account, client) { }

        protected override ERPJournal_entry_account fromERPObject(ERPObject obj)
        {
            return new ERPJournal_entry_account(obj);
        }
    }
}