using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Membership
{
    public class MembershipService : SubServiceBase<ERPMembership>
    {
        public MembershipService(ERPNextClient client)
            : base(DocType.Membership, client) { }

        protected override ERPMembership fromERPObject(ERPObject obj)
        {
            return new ERPMembership(obj);
        }
    }
}