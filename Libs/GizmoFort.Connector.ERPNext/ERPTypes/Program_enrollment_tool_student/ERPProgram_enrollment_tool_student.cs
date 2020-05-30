using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_tool_student
{
    public class ERPProgram_enrollment_tool_student : ERPNextObjectBase
    {
        public ERPProgram_enrollment_tool_student() : this(new ERPObject(DocType.Program_enrollment_tool_student)) { }
        public ERPProgram_enrollment_tool_student(ERPObject obj) : base(obj) { }

        public static ERPProgram_enrollment_tool_student Create(string studentapplicant, string student, string studentname, string studentbatchname)

        {
            ERPProgram_enrollment_tool_student obj = new ERPProgram_enrollment_tool_student();
            obj.student_applicant = studentapplicant;
            obj.student = student;
            obj.student_name = studentname;
            obj.student_batch_name = studentbatchname;
            return obj;
        }

        public string student_applicant
        {
            get { return data.student_applicant; }
            set
            {
                data.student_applicant = value;
                data.name = value;
            }

        }

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
        }

        public string student_name
        {
            get { return data.student_name; }
            set { data.student_name = value; }
        }

        public string student_batch_name
        {
            get { return data.student_batch_name; }
            set { data.student_batch_name = value; }
        }


    }

    //Enums go here

}