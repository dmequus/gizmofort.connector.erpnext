using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment
{
    public class ERPPatient_assessment : ERPNextObjectBase
    {
        public ERPPatient_assessment() : this(new ERPObject(DocType.Patient_assessment)) { }
        public ERPPatient_assessment(ERPObject obj) : base(obj) { }

        public static ERPPatient_assessment Create(string patient, string assessmenttemplate)

        {
            ERPPatient_assessment obj = new ERPPatient_assessment();
            obj.patient = patient;
            obj.assessment_template = assessmenttemplate;
            return obj;
        }

        public string patient
        {
            get { return data.patient; }
            set
            {
                data.patient = value;
                data.name = value;
            }

        }

        public string assessment_template
        {
            get { return data.assessment_template; }
            set { data.assessment_template = value; }
        }

        public string therapy_session
        {
            get { return data.therapy_session; }
            set { data.therapy_session = value; }
        }

        public string healthcare_practitioner
        {
            get { return data.healthcare_practitioner; }
            set { data.healthcare_practitioner = value; }
        }

        public string assessment_datetime
        {
            get { return data.assessment_datetime; }
            set { data.assessment_datetime = value; }
        }

        public string assessment_sheet
        {
            get { return data.assessment_sheet; }
            set { data.assessment_sheet = value; }
        }

        public int total_score
        {
            get { return data.total_score; }
            set { data.total_score = value; }
        }

        public int total_score_obtained
        {
            get { return data.total_score_obtained; }
            set { data.total_score_obtained = value; }
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

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string assessment_description
        {
            get { return data.assessment_description; }
            set { data.assessment_description = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }


    }

    //Enums go here

}