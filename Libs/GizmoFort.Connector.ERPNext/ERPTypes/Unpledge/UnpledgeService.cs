using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Unpledge
{
    public class UnpledgeService : SubServiceBase<ERPUnpledge>
    {
        public UnpledgeService(ERPNextClient client)
            : base(DocType.Unpledge, client) { }

        protected override ERPUnpledge fromERPObject(ERPObject obj)
        {
            return new ERPUnpledge(obj);
        }
    }
}