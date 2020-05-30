using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_criteria
{
    public class ERPAssessment_criteria : ERPNextObjectBase
    {
        public ERPAssessment_criteria() : this(new ERPObject(DocType.Assessment_criteria)) { }
        public ERPAssessment_criteria(ERPObject obj) : base(obj) { }

        public static ERPAssessment_criteria Create(string assessmentcriteria, string assessmentcriteriagroup)

        {
            ERPAssessment_criteria obj = new ERPAssessment_criteria();
            obj.assessment_criteria = assessmentcriteria;
            obj.assessment_criteria_group = assessmentcriteriagroup;
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

        public string assessment_criteria_group
        {
            get { return data.assessment_criteria_group; }
            set { data.assessment_criteria_group = value; }
        }


    }

    //Enums go here

}