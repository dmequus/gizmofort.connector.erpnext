using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_tool
{
    public class ERPProgram_enrollment_tool : ERPNextObjectBase
    {
        public ERPProgram_enrollment_tool() : this(new ERPObject(DocType.Program_enrollment_tool)) { }
        public ERPProgram_enrollment_tool(ERPObject obj) : base(obj) { }

        public static ERPProgram_enrollment_tool Create(Getstudentsfrom getstudentsfrom, string program, string studentbatch, string academicyear, string academicterm, string students, string newprogram, string newstudentbatch, string newacademicyear, string newacademicterm)

        {
            ERPProgram_enrollment_tool obj = new ERPProgram_enrollment_tool();
            obj.get_students_from = getstudentsfrom;
            obj.program = program;
            obj.student_batch = studentbatch;
            obj.academic_year = academicyear;
            obj.academic_term = academicterm;
            obj.students = students;
            obj.new_program = newprogram;
            obj.new_student_batch = newstudentbatch;
            obj.new_academic_year = newacademicyear;
            obj.new_academic_term = newacademicterm;
            return obj;
        }

        public Getstudentsfrom get_students_from
        {
            get { return parseEnum<Getstudentsfrom>(data.get_students_from); }
            set { data.get_students_from = value.ToString(); }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
        }

        public string student_batch
        {
            get { return data.student_batch; }
            set { data.student_batch = value; }
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

        public string students
        {
            get { return data.students; }
            set { data.students = value; }
        }

        public string new_program
        {
            get { return data.new_program; }
            set { data.new_program = value; }
        }

        public string new_student_batch
        {
            get { return data.new_student_batch; }
            set { data.new_student_batch = value; }
        }

        public string new_academic_year
        {
            get { return data.new_academic_year; }
            set { data.new_academic_year = value; }
        }

        public string new_academic_term
        {
            get { return data.new_academic_term; }
            set { data.new_academic_term = value; }
        }


    }

    //Enums go here
    public enum Getstudentsfrom
    {
        [Description("Student Applicant")]
        StudentApplicant,
        [Description("Program Enrollment")]
        ProgramEnrollment,
    }


}