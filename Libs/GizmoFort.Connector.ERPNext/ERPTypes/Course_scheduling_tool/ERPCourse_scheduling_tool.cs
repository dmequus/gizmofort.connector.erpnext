using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_scheduling_tool
{
    public class ERPCourse_scheduling_tool : ERPNextObjectBase
    {
        public ERPCourse_scheduling_tool() : this(new ERPObject(DocType.Course_scheduling_tool)) { }
        public ERPCourse_scheduling_tool(ERPObject obj) : base(obj) { }

        public static ERPCourse_scheduling_tool Create(string studentgroup, string course, string program, string academicyear, string academicterm, string instructor, string instructorname, string room, string fromtime, string coursestartdate, Day day, long reschedule, string totime, string courseenddate)

        {
            ERPCourse_scheduling_tool obj = new ERPCourse_scheduling_tool();
            obj.student_group = studentgroup;
            obj.course = course;
            obj.program = program;
            obj.academic_year = academicyear;
            obj.academic_term = academicterm;
            obj.instructor = instructor;
            obj.instructor_name = instructorname;
            obj.room = room;
            obj.from_time = fromtime;
            obj.course_start_date = coursestartdate;
            obj.day = day;
            obj.reschedule = reschedule;
            obj.to_time = totime;
            obj.course_end_date = courseenddate;
            return obj;
        }

        public string student_group
        {
            get { return data.student_group; }
            set
            {
                data.student_group = value;
                data.name = value;
            }

        }

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set { data.academic_year = value; }
        }

        public string academic_term
        {
            get { return data.academic_term; }
            set { data.academic_term = value; }
        }

        public string instructor
        {
            get { return data.instructor; }
            set { data.instructor = value; }
        }

        public string instructor_name
        {
            get { return data.instructor_name; }
            set { data.instructor_name = value; }
        }

        public string room
        {
            get { return data.room; }
            set { data.room = value; }
        }

        public string from_time
        {
            get { return data.from_time; }
            set { data.from_time = value; }
        }

        public string course_start_date
        {
            get { return data.course_start_date; }
            set { data.course_start_date = value; }
        }

        public Day day
        {
            get { return parseEnum<Day>(data.day); }
            set { data.day = value.ToString(); }
        }

        public long reschedule
        {
            get { return data.reschedule; }
            set { data.reschedule = value; }
        }

        public string to_time
        {
            get { return data.to_time; }
            set { data.to_time = value; }
        }

        public string course_end_date
        {
            get { return data.course_end_date; }
            set { data.course_end_date = value; }
        }


    }

    //Enums go here
    public enum Day
    {
        [Description("Monday")]
        Monday,
        [Description("Tuesday")]
        Tuesday,
        [Description("Wednesday")]
        Wednesday,
        [Description("Thursday")]
        Thursday,
        [Description("Friday")]
        Friday,
        [Description("Saturday")]
        Saturday,
        [Description("Sunday")]
        Sunday,
    }


}