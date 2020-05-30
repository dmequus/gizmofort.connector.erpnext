using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_plan_criteria
{
    public class ERPAssessment_plan_criteria : ERPNextObjectBase
    {
        public ERPAssessment_plan_criteria() : this(new ERPObject(DocType.Assessment_plan_criteria)) { }
        public ERPAssessment_plan_criteria(ERPObject obj) : base(obj) { }

        public static ERPAssessment_plan_criteria Create(string assessmentcriteria, double maximumscore)

        {
            ERPAssessment_plan_criteria obj = new ERPAssessment_plan_criteria();
            obj.assessment_criteria = assessmentcriteria;
            obj.maximum_score = maximumscore;
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


    }

    //Enums go here

}