using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_topic
{
    public class Course_topicService : SubServiceBase<ERPCourse_topic>
    {
        public Course_topicService(ERPNextClient client)
            : base(DocType.Course_topic, client) { }

        protected override ERPCourse_topic fromERPObject(ERPObject obj)
        {
            return new ERPCourse_topic(obj);
        }
    }
}