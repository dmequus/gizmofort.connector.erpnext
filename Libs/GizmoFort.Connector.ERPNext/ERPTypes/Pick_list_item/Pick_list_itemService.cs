using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pick_list_item
{
    public class Pick_list_itemService : SubServiceBase<ERPPick_list_item>
    {
        public Pick_list_itemService(ERPNextClient client)
            : base(DocType.Pick_list_item, client) { }

        protected override ERPPick_list_item fromERPObject(ERPObject obj)
        {
            return new ERPPick_list_item(obj);
        }
    }
}