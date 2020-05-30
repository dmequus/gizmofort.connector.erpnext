using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Downtime_entry
{
    public class Downtime_entryService : SubServiceBase<ERPDowntime_entry>
    {
        public Downtime_entryService(ERPNextClient client)
            : base(DocType.Downtime_entry, client) { }

        protected override ERPDowntime_entry fromERPObject(ERPObject obj)
        {
            return new ERPDowntime_entry(obj);
        }
    }
}