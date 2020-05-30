using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Campaign
{
    public class CampaignService : SubServiceBase<ERPCampaign>
    {
        public CampaignService(ERPNextClient client)
            : base(DocType.Campaign, client) { }

        protected override ERPCampaign fromERPObject(ERPObject obj)
        {
            return new ERPCampaign(obj);
        }
    }
}