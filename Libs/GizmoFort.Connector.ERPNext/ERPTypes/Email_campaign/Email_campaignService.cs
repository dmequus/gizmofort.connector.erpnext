using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Email_campaign
{
    public class Email_campaignService : SubServiceBase<ERPEmail_campaign>
    {
        public Email_campaignService(ERPNextClient client)
            : base(DocType.Email_campaign, client) { }

        protected override ERPEmail_campaign fromERPObject(ERPObject obj)
        {
            return new ERPEmail_campaign(obj);
        }
    }
}