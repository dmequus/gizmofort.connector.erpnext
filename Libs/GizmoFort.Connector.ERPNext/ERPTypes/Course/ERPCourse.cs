using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Course
{
    public class ERPCourse : ERPNextObjectBase
    {
        public ERPCourse() : this(new ERPObject(DocType.Course)) { }
        public ERPCourse(ERPObject obj) : base(obj) { }

        public static ERPCourse Create(string coursename)

        {
            ERPCourse obj = new ERPCourse();
            obj.course_name = coursename;
            return obj;
        }

        public string course_name
        {
            get { return data.course_name; }
            set
            {
                data.course_name = value;
                data.name = value;
            }

        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string topics
        {
            get { return data.topics; }
            set { data.topics = value; }
        }

        public string hero_image
        {
            get { return data.hero_image; }
            set { data.hero_image = value; }
        }

        public string default_grading_scale
        {
            get { return data.default_grading_scale; }
            set { data.default_grading_scale = value; }
        }

        public string assessment_criteria
        {
            get { return data.assessment_criteria; }
            set { data.assessment_criteria = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}