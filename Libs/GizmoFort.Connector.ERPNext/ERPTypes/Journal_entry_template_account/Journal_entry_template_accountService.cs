using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry_template_account
{
    public class Journal_entry_template_accountService : SubServiceBase<ERPJournal_entry_template_account>
    {
        public Journal_entry_template_accountService(ERPNextClient client)
            : base(DocType.Journal_entry_template_account, client) { }

        protected override ERPJournal_entry_template_account fromERPObject(ERPObject obj)
        {
            return new ERPJournal_entry_template_account(obj);
        }
    }
}