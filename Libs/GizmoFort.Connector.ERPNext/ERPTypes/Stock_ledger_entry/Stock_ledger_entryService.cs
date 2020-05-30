using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_ledger_entry
{
    public class Stock_ledger_entryService : SubServiceBase<ERPStock_ledger_entry>
    {
        public Stock_ledger_entryService(ERPNextClient client)
            : base(DocType.Stock_ledger_entry, client) { }

        protected override ERPStock_ledger_entry fromERPObject(ERPObject obj)
        {
            return new ERPStock_ledger_entry(obj);
        }
    }
}