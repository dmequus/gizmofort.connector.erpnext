using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_topic
{
    public class ERPCourse_topic : ERPNextObjectBase
    {
        public ERPCourse_topic() : this(new ERPObject(DocType.Course_topic)) { }
        public ERPCourse_topic(ERPObject obj) : base(obj) { }

        public static ERPCourse_topic Create(string topic, string topicname)

        {
            ERPCourse_topic obj = new ERPCourse_topic();
            obj.topic = topic;
            obj.topic_name = topicname;
            return obj;
        }

        public string topic
        {
            get { return data.topic; }
            set
            {
                data.topic = value;
                data.name = value;
            }

        }

        public string topic_name
        {
            get { return data.topic_name; }
            set { data.topic_name = value; }
        }


    }

    //Enums go here

}