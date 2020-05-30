using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_ledger_entry
{
    public class Leave_ledger_entryService : SubServiceBase<ERPLeave_ledger_entry>
    {
        public Leave_ledger_entryService(ERPNextClient client)
            : base(DocType.Leave_ledger_entry, client) { }

        protected override ERPLeave_ledger_entry fromERPObject(ERPObject obj)
        {
            return new ERPLeave_ledger_entry(obj);
        }
    }
}