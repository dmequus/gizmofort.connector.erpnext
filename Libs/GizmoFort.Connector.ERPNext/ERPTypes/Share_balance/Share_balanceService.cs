using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Share_balance
{
    public class Share_balanceService : SubServiceBase<ERPShare_balance>
    {
        public Share_balanceService(ERPNextClient client)
            : base(DocType.Share_balance, client) { }

        protected override ERPShare_balance fromERPObject(ERPObject obj)
        {
            return new ERPShare_balance(obj);
        }
    }
}