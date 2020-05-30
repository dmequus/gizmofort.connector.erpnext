using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Instructor_log
{
    public class ERPInstructor_log : ERPNextObjectBase
    {
        public ERPInstructor_log() : this(new ERPObject(DocType.Instructor_log)) { }
        public ERPInstructor_log(ERPObject obj) : base(obj) { }

        public static ERPInstructor_log Create(string academicyear, string academicterm, string department, string program, string course, string studentgroup, string otherdetails)

        {
            ERPInstructor_log obj = new ERPInstructor_log();
            obj.academic_year = academicyear;
            obj.academic_term = academicterm;
            obj.department = department;
            obj.program = program;
            obj.course = course;
            obj.student_group = studentgroup;
            obj.other_details = otherdetails;
            return obj;
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set
            {
                data.academic_year = value;
                data.name = value;
            }

        }

        public string academic_term
        {
            get { return data.academic_term; }
            set { data.academic_term = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
        }

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string student_group
        {
            get { return data.student_group; }
            set { data.student_group = value; }
        }

        public string other_details
        {
            get { return data.other_details; }
            set { data.other_details = value; }
        }


    }

    //Enums go here

}