using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry
{
    public class Journal_entryService : SubServiceBase<ERPJournal_entry>
    {
        public Journal_entryService(ERPNextClient client)
            : base(DocType.Journal_entry, client) { }

        protected override ERPJournal_entry fromERPObject(ERPObject obj)
        {
            return new ERPJournal_entry(obj);
        }
    }
}