using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_report_generation_tool
{
    public class ERPStudent_report_generation_tool : ERPNextObjectBase
    {
        public ERPStudent_report_generation_tool() : this(new ERPObject(DocType.Student_report_generation_tool)) { }
        public ERPStudent_report_generation_tool(ERPObject obj) : base(obj) { }

        public static ERPStudent_report_generation_tool Create(string student, string studentname, string program, string studentbatch, long includeallassessment, long showmarks, long addletterhead, string assessmentgroup, string academicyear, string academicterm, string letterhead, string parentsmeeting, string parentsattendance, string terms, string assessmentterms)

        {
            ERPStudent_report_generation_tool obj = new ERPStudent_report_generation_tool();
            obj.student = student;
            obj.student_name = studentname;
            obj.program = program;
            obj.student_batch = studentbatch;
            obj.include_all_assessment = includeallassessment;
            obj.show_marks = showmarks;
            obj.add_letterhead = addletterhead;
            obj.assessment_group = assessmentgroup;
            obj.academic_year = academicyear;
            obj.academic_term = academicterm;
            obj.letter_head = letterhead;
            obj.parents_meeting = parentsmeeting;
            obj.parents_attendance = parentsattendance;
            obj.terms = terms;
            obj.assessment_terms = assessmentterms;
            return obj;
        }

        public string student
        {
            get { return data.student; }
            set
            {
                data.student = value;
                data.name = value;
            }

        }

        public string student_name
        {
            get { return data.student_name; }
            set { data.student_name = value; }
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

        public long include_all_assessment
        {
            get { return data.include_all_assessment; }
            set { data.include_all_assessment = value; }
        }

        public long show_marks
        {
            get { return data.show_marks; }
            set { data.show_marks = value; }
        }

        public long add_letterhead
        {
            get { return data.add_letterhead; }
            set { data.add_letterhead = value; }
        }

        public string assessment_group
        {
            get { return data.assessment_group; }
            set { data.assessment_group = value; }
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

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string parents_meeting
        {
            get { return data.parents_meeting; }
            set { data.parents_meeting = value; }
        }

        public string parents_attendance
        {
            get { return data.parents_attendance; }
            set { data.parents_attendance = value; }
        }

        public string terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        public string assessment_terms
        {
            get { return data.assessment_terms; }
            set { data.assessment_terms = value; }
        }


    }

    //Enums go here

}