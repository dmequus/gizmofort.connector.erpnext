using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_enrollment
{
    public class ERPCourse_enrollment : ERPNextObjectBase
    {
        public ERPCourse_enrollment() : this(new ERPObject(DocType.Course_enrollment)) { }
        public ERPCourse_enrollment(ERPObject obj) : base(obj) { }

        public static ERPCourse_enrollment Create(string programenrollment, string student, string course, string enrollmentdate)

        {
            ERPCourse_enrollment obj = new ERPCourse_enrollment();
            obj.program_enrollment = programenrollment;
            obj.student = student;
            obj.course = course;
            obj.enrollment_date = enrollmentdate;
            return obj;
        }

        public string program_enrollment
        {
            get { return data.program_enrollment; }
            set
            {
                data.program_enrollment = value;
                data.name = value;
            }

        }

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
        }

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string enrollment_date
        {
            get { return data.enrollment_date; }
            set { data.enrollment_date = value; }
        }


    }

    //Enums go here

}