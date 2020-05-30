using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Member
{
    public class MemberService : SubServiceBase<ERPMember>
    {
        public MemberService(ERPNextClient client)
            : base(DocType.Member, client) { }

        protected override ERPMember fromERPObject(ERPObject obj)
        {
            return new ERPMember(obj);
        }
    }
}