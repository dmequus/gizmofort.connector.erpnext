using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_schedule
{
    public class ERPCourse_schedule : ERPNextObjectBase
    {
        public ERPCourse_schedule() : this(new ERPObject(DocType.Course_schedule)) { }
        public ERPCourse_schedule(ERPObject obj) : base(obj) { }

        public static ERPCourse_schedule Create(string title, string studentgroup, string instructor, string instructorname, string namingseries, string course, string color, string scheduledate, string room, string fromtime, string totime)

        {
            ERPCourse_schedule obj = new ERPCourse_schedule();
            obj.title = title;
            obj.student_group = studentgroup;
            obj.instructor = instructor;
            obj.instructor_name = instructorname;
            obj.naming_series = namingseries;
            obj.course = course;
            obj.color = color;
            obj.schedule_date = scheduledate;
            obj.room = room;
            obj.from_time = fromtime;
            obj.to_time = totime;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string student_group
        {
            get { return data.student_group; }
            set { data.student_group = value; }
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

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string color
        {
            get { return data.color; }
            set { data.color = value; }
        }

        public string schedule_date
        {
            get { return data.schedule_date; }
            set { data.schedule_date = value; }
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

        public string to_time
        {
            get { return data.to_time; }
            set { data.to_time = value; }
        }


    }

    //Enums go here

}