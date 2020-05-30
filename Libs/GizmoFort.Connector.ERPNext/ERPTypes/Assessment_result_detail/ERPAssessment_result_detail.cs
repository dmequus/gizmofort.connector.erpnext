using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_result_detail
{
    public class ERPAssessment_result_detail : ERPNextObjectBase
    {
        public ERPAssessment_result_detail() : this(new ERPObject(DocType.Assessment_result_detail)) { }
        public ERPAssessment_result_detail(ERPObject obj) : base(obj) { }

        public static ERPAssessment_result_detail Create(string assessmentcriteria, double maximumscore, double score, string grade)

        {
            ERPAssessment_result_detail obj = new ERPAssessment_result_detail();
            obj.assessment_criteria = assessmentcriteria;
            obj.maximum_score = maximumscore;
            obj.score = score;
            obj.grade = grade;
            return obj;
        }

        public string assessment_criteria
        {
            get { return data.assessment_criteria; }
            set
            {
                data.assessment_criteria = value;
                data.name = value;
            }

        }

        private double _maximum_score = 0.0;
        public double maximum_score
        {
            get { return data._maximum_score; }
            set { data._maximum_score = value; }
        }

        private double _score = 0.0;
        public double score
        {
            get { return data._score; }
            set { data._score = value; }
        }

        public string grade
        {
            get { return data.grade; }
            set { data.grade = value; }
        }


    }

    //Enums go here

}