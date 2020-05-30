using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry_template
{
    public class Journal_entry_templateService : SubServiceBase<ERPJournal_entry_template>
    {
        public Journal_entry_templateService(ERPNextClient client)
            : base(DocType.Journal_entry_template, client) { }

        protected override ERPJournal_entry_template fromERPObject(ERPObject obj)
        {
            return new ERPJournal_entry_template(obj);
        }
    }
}