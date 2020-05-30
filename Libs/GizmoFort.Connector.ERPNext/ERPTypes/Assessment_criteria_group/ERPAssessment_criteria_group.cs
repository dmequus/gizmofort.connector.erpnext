using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_criteria_group
{
    public class ERPAssessment_criteria_group : ERPNextObjectBase
    {
        public ERPAssessment_criteria_group() : this(new ERPObject(DocType.Assessment_criteria_group)) { }
        public ERPAssessment_criteria_group(ERPObject obj) : base(obj) { }

        public static ERPAssessment_criteria_group Create(string assessmentcriteriagroup)

        {
            ERPAssessment_criteria_group obj = new ERPAssessment_criteria_group();
            obj.assessment_criteria_group = assessmentcriteriagroup;
            return obj;
        }

        public string assessment_criteria_group
        {
            get { return data.assessment_criteria_group; }
            set
            {
                data.assessment_criteria_group = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}