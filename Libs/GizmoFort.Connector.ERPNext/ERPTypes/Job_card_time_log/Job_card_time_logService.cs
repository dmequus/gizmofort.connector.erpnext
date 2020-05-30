using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_card_time_log
{
    public class Job_card_time_logService : SubServiceBase<ERPJob_card_time_log>
    {
        public Job_card_time_logService(ERPNextClient client)
            : base(DocType.Job_card_time_log, client) { }

        protected override ERPJob_card_time_log fromERPObject(ERPObject obj)
        {
            return new ERPJob_card_time_log(obj);
        }
    }
}