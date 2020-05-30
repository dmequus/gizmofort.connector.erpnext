using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Topic
{
    public class ERPTopic : ERPNextObjectBase
    {
        public ERPTopic() : this(new ERPObject(DocType.Topic)) { }
        public ERPTopic(ERPObject obj) : base(obj) { }

        public static ERPTopic Create(string topicname)

        {
            ERPTopic obj = new ERPTopic();
            obj.topic_name = topicname;
            return obj;
        }

        public string topic_name
        {
            get { return data.topic_name; }
            set
            {
                data.topic_name = value;
                data.name = value;
            }

        }

        public string topic_content
        {
            get { return data.topic_content; }
            set { data.topic_content = value; }
        }

        public string hero_image
        {
            get { return data.hero_image; }
            set { data.hero_image = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}