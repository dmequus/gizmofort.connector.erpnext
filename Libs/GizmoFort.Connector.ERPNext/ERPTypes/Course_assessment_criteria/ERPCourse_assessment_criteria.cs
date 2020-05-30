using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_assessment_criteria
{
    public class ERPCourse_assessment_criteria : ERPNextObjectBase
    {
        public ERPCourse_assessment_criteria() : this(new ERPObject(DocType.Course_assessment_criteria)) { }
        public ERPCourse_assessment_criteria(ERPObject obj) : base(obj) { }

        public static ERPCourse_assessment_criteria Create(string assessmentcriteria, double weightage)

        {
            ERPCourse_assessment_criteria obj = new ERPCourse_assessment_criteria();
            obj.assessment_criteria = assessmentcriteria;
            obj.weightage = weightage;
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

        private double _weightage = 0.0;
        public double weightage
        {
            get { return data._weightage; }
            set { data._weightage = value; }
        }


    }

    //Enums go here

}