using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group
{
    public class ERPStudent_group : ERPNextObjectBase
    {
        public ERPStudent_group() : this(new ERPObject(DocType.Student_group)) { }
        public ERPStudent_group(ERPObject obj) : base(obj) { }

        public static ERPStudent_group Create(Groupbasedon groupbasedon, string studentgroupname)

        {
            ERPStudent_group obj = new ERPStudent_group();
            obj.group_based_on = groupbasedon;
            obj.student_group_name = studentgroupname;
            return obj;
        }

        public Groupbasedon group_based_on
        {
            get { return parseEnum<Groupbasedon>(data.group_based_on); }
            set { data.group_based_on = value.ToString(); }
        }

        public string student_group_name
        {
            get { return data.student_group_name; }
            set { data.student_group_name = value; }
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set { data.academic_year = value; }
        }

        public int max_strength
        {
            get { return data.max_strength; }
            set { data.max_strength = value; }
        }

        public string academic_term
        {
            get { return data.academic_term; }
            set { data.academic_term = value; }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
        }

        public string batch
        {
            get { return data.batch; }
            set { data.batch = value; }
        }

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string students
        {
            get { return data.students; }
            set { data.students = value; }
        }

        public string instructors
        {
            get { return data.instructors; }
            set { data.instructors = value; }
        }

        public string student_category
        {
            get { return data.student_category; }
            set { data.student_category = value; }
        }


    }

    //Enums go here
    public enum Groupbasedon
    {
        [Description("Batch")]
        Batch,
        [Description("Course")]
        Course,
        [Description("Activity")]
        Activity,
    }


}