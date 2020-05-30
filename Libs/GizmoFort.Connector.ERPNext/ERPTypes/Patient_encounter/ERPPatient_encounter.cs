using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_encounter
{
    public class ERPPatient_encounter : ERPNextObjectBase
    {
        public ERPPatient_encounter() : this(new ERPObject(DocType.Patient_encounter)) { }
        public ERPPatient_encounter(ERPObject obj) : base(obj) { }

        public static ERPPatient_encounter Create(string title, string patient, string practitioner, string encounterdate, string encountertime)

        {
            ERPPatient_encounter obj = new ERPPatient_encounter();
            obj.title = title;
            obj.patient = patient;
            obj.practitioner = practitioner;
            obj.encounter_date = encounterdate;
            obj.encounter_time = encountertime;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string patient
        {
            get { return data.patient; }
            set { data.patient = value; }
        }

        public string practitioner
        {
            get { return data.practitioner; }
            set { data.practitioner = value; }
        }

        public string encounter_date
        {
            get { return data.encounter_date; }
            set { data.encounter_date = value; }
        }

        public string encounter_time
        {
            get { return data.encounter_time; }
            set { data.encounter_time = value; }
        }

        public string inpatient_record
        {
            get { return data.inpatient_record; }
            set { data.inpatient_record = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string appointment
        {
            get { return data.appointment; }
            set { data.appointment = value; }
        }

        public string patient_name
        {
            get { return data.patient_name; }
            set { data.patient_name = value; }
        }

        public string patient_age
        {
            get { return data.patient_age; }
            set { data.patient_age = value; }
        }

        public string patient_sex
        {
            get { return data.patient_sex; }
            set { data.patient_sex = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private int _invoiced = 0;
        public int invoiced
        {
            get { return data._invoiced; }
            set { data._invoiced = value; }
        }

        public string symptoms
        {
            get { return data.symptoms; }
            set { data.symptoms = value; }
        }

        private int _symptoms_in_print = 0;
        public int symptoms_in_print
        {
            get { return data._symptoms_in_print; }
            set { data._symptoms_in_print = value; }
        }

        public string diagnosis
        {
            get { return data.diagnosis; }
            set { data.diagnosis = value; }
        }

        private int _diagnosis_in_print = 0;
        public int diagnosis_in_print
        {
            get { return data._diagnosis_in_print; }
            set { data._diagnosis_in_print = value; }
        }

        public string codification_table
        {
            get { return data.codification_table; }
            set { data.codification_table = value; }
        }

        public string drug_prescription
        {
            get { return data.drug_prescription; }
            set { data.drug_prescription = value; }
        }

        public string lab_test_prescription
        {
            get { return data.lab_test_prescription; }
            set { data.lab_test_prescription = value; }
        }

        public string procedure_prescription
        {
            get { return data.procedure_prescription; }
            set { data.procedure_prescription = value; }
        }

        public string encounter_comment
        {
            get { return data.encounter_comment; }
            set { data.encounter_comment = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string therapies
        {
            get { return data.therapies; }
            set { data.therapies = value; }
        }

        public string therapy_plan
        {
            get { return data.therapy_plan; }
            set { data.therapy_plan = value; }
        }

        public string appointment_type
        {
            get { return data.appointment_type; }
            set { data.appointment_type = value; }
        }

        public string medical_department
        {
            get { return data.medical_department; }
            set { data.medical_department = value; }
        }

        public string inpatient_status
        {
            get { return data.inpatient_status; }
            set { data.inpatient_status = value; }
        }

        public string practitioner_name
        {
            get { return data.practitioner_name; }
            set { data.practitioner_name = value; }
        }


    }

    //Enums go here

}