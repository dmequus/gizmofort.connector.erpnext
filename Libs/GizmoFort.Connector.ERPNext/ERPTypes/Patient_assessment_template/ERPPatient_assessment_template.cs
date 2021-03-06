using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_template
{
    public class ERPPatient_assessment_template : ERPNextObjectBase
    {
        public ERPPatient_assessment_template() : this(new ERPObject(DocType.Patient_assessment_template)) { }
        public ERPPatient_assessment_template(ERPObject obj) : base(obj) { }

        public static ERPPatient_assessment_template Create(string assessmentname)

        {
            ERPPatient_assessment_template obj = new ERPPatient_assessment_template();
            obj.assessment_name = assessmentname;
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

        public string parameters
        {
            get { return data.parameters; }
            set { data.parameters = value; }
        }

        public int scale_min
        {
            get { return data.scale_min; }
            set { data.scale_min = value; }
        }

        public int scale_max
        {
            get { return data.scale_max; }
            set { data.scale_max = value; }
        }

        public string assessment_description
        {
            get { return data.assessment_description; }
            set { data.assessment_description = value; }
        }


    }

    //Enums go here

}