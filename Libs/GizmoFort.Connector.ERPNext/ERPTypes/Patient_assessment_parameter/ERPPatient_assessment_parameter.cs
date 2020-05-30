using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_parameter
{
    public class ERPPatient_assessment_parameter : ERPNextObjectBase
    {
        public ERPPatient_assessment_parameter() : this(new ERPObject(DocType.Patient_assessment_parameter)) { }
        public ERPPatient_assessment_parameter(ERPObject obj) : base(obj) { }

        public static ERPPatient_assessment_parameter Create(string assessmentparameter)

        {
            ERPPatient_assessment_parameter obj = new ERPPatient_assessment_parameter();
            obj.assessment_parameter = assessmentparameter;
            return obj;
        }

        public string assessment_parameter
        {
            get { return data.assessment_parameter; }
            set
            {
                data.assessment_parameter = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}