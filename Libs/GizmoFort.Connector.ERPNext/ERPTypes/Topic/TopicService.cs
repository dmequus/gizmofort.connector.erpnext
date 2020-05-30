using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Topic
{
    public class TopicService : SubServiceBase<ERPTopic>
    {
        public TopicService(ERPNextClient client)
            : base(DocType.Topic, client) { }

        protected override ERPTopic fromERPObject(ERPObject obj)
        {
            return new ERPTopic(obj);
        }
    }
}