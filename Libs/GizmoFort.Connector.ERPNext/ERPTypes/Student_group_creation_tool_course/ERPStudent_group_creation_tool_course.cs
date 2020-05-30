using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group_creation_tool_course
{
    public class ERPStudent_group_creation_tool_course : ERPNextObjectBase
    {
        public ERPStudent_group_creation_tool_course() : this(new ERPObject(DocType.Student_group_creation_tool_course)) { }
        public ERPStudent_group_creation_tool_course(ERPObject obj) : base(obj) { }

        public static ERPStudent_group_creation_tool_course Create(Groupbasedon groupbasedon, string course, string batch, string studentgroupname, string coursecode, int maxstrength)

        {
            ERPStudent_group_creation_tool_course obj = new ERPStudent_group_creation_tool_course();
            obj.group_based_on = groupbasedon;
            obj.course = course;
            obj.batch = batch;
            obj.student_group_name = studentgroupname;
            obj.course_code = coursecode;
            obj.max_strength = maxstrength;
            return obj;
        }

        public Groupbasedon group_based_on
        {
            get { return parseEnum<Groupbasedon>(data.group_based_on); }
            set { data.group_based_on = value.ToString(); }
        }

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string batch
        {
            get { return data.batch; }
            set { data.batch = value; }
        }

        public string student_group_name
        {
            get { return data.student_group_name; }
            set { data.student_group_name = value; }
        }

        public string course_code
        {
            get { return data.course_code; }
            set { data.course_code = value; }
        }

        private int _max_strength = 0;
        public int max_strength
        {
            get { return data._max_strength; }
            set { data._max_strength = value; }
        }


    }

    //Enums go here
    public enum Groupbasedon
    {
        [Description("Batch")]
        Batch,
        [Description("Course")]
        Course,
    }


}