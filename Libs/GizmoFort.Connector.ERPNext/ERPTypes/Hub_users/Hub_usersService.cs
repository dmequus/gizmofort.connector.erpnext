using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hub_users
{
    public class Hub_usersService : SubServiceBase<ERPHub_users>
    {
        public Hub_usersService(ERPNextClient client)
            : base(DocType.Hub_users, client) { }

        protected override ERPHub_users fromERPObject(ERPObject obj)
        {
            return new ERPHub_users(obj);
        }
    }
}