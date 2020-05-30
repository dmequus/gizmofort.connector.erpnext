using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_content
{
    public class ERPCourse_content : ERPNextObjectBase
    {
        public ERPCourse_content() : this(new ERPObject(DocType.Course_content)) { }
        public ERPCourse_content(ERPObject obj) : base(obj) { }

        public static ERPCourse_content Create(Contenttype contenttype, string content)

        {
            ERPCourse_content obj = new ERPCourse_content();
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