using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_item_group
{
    public class Pos_item_groupService : SubServiceBase<ERPPos_item_group>
    {
        public Pos_item_groupService(ERPNextClient client)
            : base(DocType.Pos_item_group, client) { }

        protected override ERPPos_item_group fromERPObject(ERPObject obj)
        {
            return new ERPPos_item_group(obj);
        }
    }
}