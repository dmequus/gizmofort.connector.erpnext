using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_group
{
    public class Item_groupService : SubServiceBase<ERPItem_group>
    {
        public Item_groupService(ERPNextClient client)
            : base(DocType.Item_group, client) { }

        protected override ERPItem_group fromERPObject(ERPObject obj)
        {
            return new ERPItem_group(obj);
        }
    }
}