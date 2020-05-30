using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Interest
{
    public class InterestService : SubServiceBase<ERPInterest>
    {
        public InterestService(ERPNextClient client)
            : base(DocType.Interest, client) { }

        protected override ERPInterest fromERPObject(ERPObject obj)
        {
            return new ERPInterest(obj);
        }
    }
}