using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_activity
{
    public class ERPCourse_activity : ERPNextObjectBase
    {
        public ERPCourse_activity() : this(new ERPObject(DocType.Course_activity)) { }
        public ERPCourse_activity(ERPObject obj) : base(obj) { }

        public static ERPCourse_activity Create(string enrollment, string course, string student, Contenttype contenttype, string content, string activitydate)

        {
            ERPCourse_activity obj = new ERPCourse_activity();
            obj.enrollment = enrollment;
            obj.course = course;
            obj.student = student;
            obj.content_type = contenttype;
            obj.content = content;
            obj.activity_date = activitydate;
            return obj;
        }

        public string enrollment
        {
            get { return data.enrollment; }
            set
            {
                data.enrollment = value;
                data.name = value;
            }

        }

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
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

        public string activity_date
        {
            get { return data.activity_date; }
            set { data.activity_date = value; }
        }


    }

    //Enums go here
    public enum Contenttype
    {
        [Description("Article")]
        Article,
        [Description("Video")]
        Video,
    }


}