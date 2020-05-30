using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hub_tracked_item
{
    public class Hub_tracked_itemService : SubServiceBase<ERPHub_tracked_item>
    {
        public Hub_tracked_itemService(ERPNextClient client)
            : base(DocType.Hub_tracked_item, client) { }

        protected override ERPHub_tracked_item fromERPObject(ERPObject obj)
        {
            return new ERPHub_tracked_item(obj);
        }
    }
}