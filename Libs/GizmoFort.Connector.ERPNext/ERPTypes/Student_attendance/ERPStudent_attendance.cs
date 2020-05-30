using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_attendance
{
    public class ERPStudent_attendance : ERPNextObjectBase
    {
        public ERPStudent_attendance() : this(new ERPObject(DocType.Student_attendance)) { }
        public ERPStudent_attendance(ERPObject obj) : base(obj) { }

        public static ERPStudent_attendance Create(string studentname, string student, string courseschedule, string date, string studentgroup, Status status)

        {
            ERPStudent_attendance obj = new ERPStudent_attendance();
            obj.student_name = studentname;
            obj.student = student;
            obj.course_schedule = courseschedule;
            obj.date = date;
            obj.student_group = studentgroup;
            obj.status = status;
            return obj;
        }

        public string student_name
        {
            get { return data.student_name; }
            set
            {
                data.student_name = value;
                data.name = value;
            }

        }

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
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

        public string student_group
        {
            get { return data.student_group; }
            set { data.student_group = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Present")]
        Present,
        [Description("Absent")]
        Absent,
    }


}