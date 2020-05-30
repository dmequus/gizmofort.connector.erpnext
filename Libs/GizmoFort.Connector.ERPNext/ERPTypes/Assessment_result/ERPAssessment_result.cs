using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_result
{
    public class ERPAssessment_result : ERPNextObjectBase
    {
        public ERPAssessment_result() : this(new ERPObject(DocType.Assessment_result)) { }
        public ERPAssessment_result(ERPObject obj) : base(obj) { }

        public static ERPAssessment_result Create(string studentname, string assessmentplan, string program, string course, string academicyear, string academicterm, string student, string studentgroup, string assessmentgroup, string gradingscale, string details, double maximumscore, double totalscore, string grade, string comment, string amendedfrom)

        {
            ERPAssessment_result obj = new ERPAssessment_result();
            obj.student_name = studentname;
            obj.assessment_plan = assessmentplan;
            obj.program = program;
            obj.course = course;
            obj.academic_year = academicyear;
            obj.academic_term = academicterm;
            obj.student = student;
            obj.student_group = studentgroup;
            obj.assessment_group = assessmentgroup;
            obj.grading_scale = gradingscale;
            obj.details = details;
            obj.maximum_score = maximumscore;
            obj.total_score = totalscore;
            obj.grade = grade;
            obj.comment = comment;
            obj.amended_from = amendedfrom;
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

        public string assessment_plan
        {
            get { return data.assessment_plan; }
            set { data.assessment_plan = value; }
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

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
        }

        public string student_group
        {
            get { return data.student_group; }
            set { data.student_group = value; }
        }

        public string assessment_group
        {
            get { return data.assessment_group; }
            set { data.assessment_group = value; }
        }

        public string grading_scale
        {
            get { return data.grading_scale; }
            set { data.grading_scale = value; }
        }

        public string details
        {
            get { return data.details; }
            set { data.details = value; }
        }

        private double _maximum_score = 0.0;
        public double maximum_score
        {
            get { return data._maximum_score; }
            set { data._maximum_score = value; }
        }

        private double _total_score = 0.0;
        public double total_score
        {
            get { return data._total_score; }
            set { data._total_score = value; }
        }

        public string grade
        {
            get { return data.grade; }
            set { data.grade = value; }
        }

        public string comment
        {
            get { return data.comment; }
            set { data.comment = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}