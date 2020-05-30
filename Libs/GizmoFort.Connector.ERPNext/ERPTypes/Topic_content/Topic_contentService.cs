using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Topic_content
{
    public class Topic_contentService : SubServiceBase<ERPTopic_content>
    {
        public Topic_contentService(ERPNextClient client)
            : base(DocType.Topic_content, client) { }

        protected override ERPTopic_content fromERPObject(ERPObject obj)
        {
            return new ERPTopic_content(obj);
        }
    }
}