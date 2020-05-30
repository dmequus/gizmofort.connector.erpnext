using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_profile
{
    public class Pos_profileService : SubServiceBase<ERPPos_profile>
    {
        public Pos_profileService(ERPNextClient client)
            : base(DocType.Pos_profile, client) { }

        protected override ERPPos_profile fromERPObject(ERPObject obj)
        {
            return new ERPPos_profile(obj);
        }
    }
}