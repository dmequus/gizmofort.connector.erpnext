using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_entry
{
    public class Stock_entryService : SubServiceBase<ERPStock_entry>
    {
        public Stock_entryService(ERPNextClient client)
            : base(DocType.Stock_entry, client) { }

        protected override ERPStock_entry fromERPObject(ERPObject obj)
        {
            return new ERPStock_entry(obj);
        }
    }
}