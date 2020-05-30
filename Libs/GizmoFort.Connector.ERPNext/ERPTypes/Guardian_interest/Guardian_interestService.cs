using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Guardian_interest
{
    public class Guardian_interestService : SubServiceBase<ERPGuardian_interest>
    {
        public Guardian_interestService(ERPNextClient client)
            : base(DocType.Guardian_interest, client) { }

        protected override ERPGuardian_interest fromERPObject(ERPObject obj)
        {
            return new ERPGuardian_interest(obj);
        }
    }
}