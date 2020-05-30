using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Campaign_email_schedule
{
    public class Campaign_email_scheduleService : SubServiceBase<ERPCampaign_email_schedule>
    {
        public Campaign_email_scheduleService(ERPNextClient client)
            : base(DocType.Campaign_email_schedule, client) { }

        protected override ERPCampaign_email_schedule fromERPObject(ERPObject obj)
        {
            return new ERPCampaign_email_schedule(obj);
        }
    }
}