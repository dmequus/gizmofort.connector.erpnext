using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_profile_user
{
    public class Pos_profile_userService : SubServiceBase<ERPPos_profile_user>
    {
        public Pos_profile_userService(ERPNextClient client)
            : base(DocType.Pos_profile_user, client) { }

        protected override ERPPos_profile_user fromERPObject(ERPObject obj)
        {
            return new ERPPos_profile_user(obj);
        }
    }
}