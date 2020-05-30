using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_detail
{
    public class ERPPatient_assessment_detail : ERPNextObjectBase
    {
        public ERPPatient_assessment_detail() : this(new ERPObject(DocType.Patient_assessment_detail)) { }
        public ERPPatient_assessment_detail(ERPObject obj) : base(obj) { }

        public static ERPPatient_assessment_detail Create(string assessmentparameter)

        {
            ERPPatient_assessment_detail obj = new ERPPatient_assessment_detail();
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