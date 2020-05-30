using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_point_entry
{
    public class Loyalty_point_entryService : SubServiceBase<ERPLoyalty_point_entry>
    {
        public Loyalty_point_entryService(ERPNextClient client)
            : base(DocType.Loyalty_point_entry, client) { }

        protected override ERPLoyalty_point_entry fromERPObject(ERPObject obj)
        {
            return new ERPLoyalty_point_entry(obj);
        }
    }
}