using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Exchange_rate_revaluation_account
{
    public class Exchange_rate_revaluation_accountService : SubServiceBase<ERPExchange_rate_revaluation_account>
    {
        public Exchange_rate_revaluation_accountService(ERPNextClient client)
            : base(DocType.Exchange_rate_revaluation_account, client) { }

        protected override ERPExchange_rate_revaluation_account fromERPObject(ERPObject obj)
        {
            return new ERPExchange_rate_revaluation_account(obj);
        }
    }
}