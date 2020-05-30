using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_reorder
{
    public class Item_reorderService : SubServiceBase<ERPItem_reorder>
    {
        public Item_reorderService(ERPNextClient client)
            : base(DocType.Item_reorder, client) { }

        protected override ERPItem_reorder fromERPObject(ERPObject obj)
        {
            return new ERPItem_reorder(obj);
        }
    }
}