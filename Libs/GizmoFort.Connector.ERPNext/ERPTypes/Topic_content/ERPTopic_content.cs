using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Topic_content
{
    public class ERPTopic_content : ERPNextObjectBase
    {
        public ERPTopic_content() : this(new ERPObject(DocType.Topic_content)) { }
        public ERPTopic_content(ERPObject obj) : base(obj) { }

        public static ERPTopic_content Create(Contenttype contenttype, string content)

        {
            ERPTopic_content obj = new ERPTopic_content();
            obj.content_type = contenttype;
            obj.content = content;
            return obj;
        }

        public Contenttype content_type
        {
            get { return parseEnum<Contenttype>(data.content_type); }
            set { data.content_type = value.ToString(); }
        }

        public string content
        {
            get { return data.content; }
            set { data.content = value; }
        }


    }

    //Enums go here
    public enum Contenttype
    {
        [Description("Article")]
        Article,
        [Description("Video")]
        Video,
        [Description("Quiz")]
        Quiz,
    }


}