using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website_item_group
{
    public class Website_item_groupService : SubServiceBase<ERPWebsite_item_group>
    {
        public Website_item_groupService(ERPNextClient client)
            : base(DocType.Website_item_group, client) { }

        protected override ERPWebsite_item_group fromERPObject(ERPObject obj)
        {
            return new ERPWebsite_item_group(obj);
        }
    }
}