using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Exchange_rate_revaluation
{
    public class Exchange_rate_revaluationService : SubServiceBase<ERPExchange_rate_revaluation>
    {
        public Exchange_rate_revaluationService(ERPNextClient client)
            : base(DocType.Exchange_rate_revaluation, client) { }

        protected override ERPExchange_rate_revaluation fromERPObject(ERPObject obj)
        {
            return new ERPExchange_rate_revaluation(obj);
        }
    }
}