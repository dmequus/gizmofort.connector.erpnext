using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_plan
{
    public class ERPAssessment_plan : ERPNextObjectBase
    {
        public ERPAssessment_plan() : this(new ERPObject(DocType.Assessment_plan)) { }
        public ERPAssessment_plan(ERPObject obj) : base(obj) { }

        public static ERPAssessment_plan Create(string assessmentname, string studentgroup, string assessmentgroup, string gradingscale, string course, string scheduledate, string fromtime, string totime, double maximumassessmentscore, string assessmentcriteria)

        {
            ERPAssessment_plan obj = new ERPAssessment_plan();
            obj.assessment_name = assessmentname;
            obj.student_group = studentgroup;
            obj.assessment_group = assessmentgroup;
            obj.grading_scale = gradingscale;
            obj.course = course;
            obj.schedule_date = scheduledate;
            obj.from_time = fromtime;
            obj.to_time = totime;
            obj.maximum_assessment_score = maximumassessmentscore;
            obj.assessment_criteria = assessmentcriteria;
            return obj;
        }

        public string assessment_name
        {
            get { return data.assessment_name; }
            set
            {
                data.assessment_name = value;
                data.name = value;
            }

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

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string schedule_date
        {
            get { return data.schedule_date; }
            set { data.schedule_date = value; }
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

        private double _maximum_assessment_score = 0.0;
        public double maximum_assessment_score
        {
            get { return data._maximum_assessment_score; }
            set { data._maximum_assessment_score = value; }
        }

        public string assessment_criteria
        {
            get { return data.assessment_criteria; }
            set { data.assessment_criteria = value; }
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

        public string room
        {
            get { return data.room; }
            set { data.room = value; }
        }

        public string examiner
        {
            get { return data.examiner; }
            set { data.examiner = value; }
        }

        public string examiner_name
        {
            get { return data.examiner_name; }
            set { data.examiner_name = value; }
        }

        public string supervisor
        {
            get { return data.supervisor; }
            set { data.supervisor = value; }
        }

        public string supervisor_name
        {
            get { return data.supervisor_name; }
            set { data.supervisor_name = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}