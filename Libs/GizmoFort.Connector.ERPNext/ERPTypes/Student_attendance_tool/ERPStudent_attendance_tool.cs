using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_attendance_tool
{
    public class ERPStudent_attendance_tool : ERPNextObjectBase
    {
        public ERPStudent_attendance_tool() : this(new ERPObject(DocType.Student_attendance_tool)) { }
        public ERPStudent_attendance_tool(ERPObject obj) : base(obj) { }

        public static ERPStudent_attendance_tool Create(Basedon basedon, Groupbasedon groupbasedon, string studentgroup, string courseschedule, string date, string studentshtml)

        {
            ERPStudent_attendance_tool obj = new ERPStudent_attendance_tool();
            obj.based_on = basedon;
            obj.group_based_on = groupbasedon;
            obj.student_group = studentgroup;
            obj.course_schedule = courseschedule;
            obj.date = date;
            obj.students_html = studentshtml;
            return obj;
        }

        public Basedon based_on
        {
            get { return parseEnum<Basedon>(data.based_on); }
            set { data.based_on = value.ToString(); }
        }

        public Groupbasedon group_based_on
        {
            get { return parseEnum<Groupbasedon>(data.group_based_on); }
            set { data.group_based_on = value.ToString(); }
        }

        public string student_group
        {
            get { return data.student_group; }
            set { data.student_group = value; }
        }

        public string course_schedule
        {
            get { return data.course_schedule; }
            set { data.course_schedule = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string students_html
        {
            get { return data.students_html; }
            set { data.students_html = value; }
        }


    }

    //Enums go here
    public enum Basedon
    {
        [Description("Student Group")]
        StudentGroup,
        [Description("Course Schedule")]
        CourseSchedule,
    }

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