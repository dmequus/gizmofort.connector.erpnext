using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hub_user
{
    public class Hub_userService : SubServiceBase<ERPHub_user>
    {
        public Hub_userService(ERPNextClient client)
            : base(DocType.Hub_user, client) { }

        protected override ERPHub_user fromERPObject(ERPObject obj)
        {
            return new ERPHub_user(obj);
        }
    }
}