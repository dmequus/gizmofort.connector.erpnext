using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_course
{
    public class ERPProgram_enrollment_course : ERPNextObjectBase
    {
        public ERPProgram_enrollment_course() : this(new ERPObject(DocType.Program_enrollment_course)) { }
        public ERPProgram_enrollment_course(ERPObject obj) : base(obj) { }

        public static ERPProgram_enrollment_course Create(string course, string coursename)

        {
            ERPProgram_enrollment_course obj = new ERPProgram_enrollment_course();
            obj.course = course;
            obj.course_name = coursename;
            return obj;
        }

        public string course
        {
            get { return data.course; }
            set
            {
                data.course = value;
                data.name = value;
            }

        }

        public string course_name
        {
            get { return data.course_name; }
            set { data.course_name = value; }
        }


    }

    //Enums go here

}