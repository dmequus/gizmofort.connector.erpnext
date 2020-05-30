using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Inpatient_record
{
    public class ERPInpatient_record : ERPNextObjectBase
    {
        public ERPInpatient_record() : this(new ERPObject(DocType.Inpatient_record)) { }
        public ERPInpatient_record(ERPObject obj) : base(obj) { }

        public static ERPInpatient_record Create(string patient, string scheduleddate)

        {
            ERPInpatient_record obj = new ERPInpatient_record();
            obj.patient = patient;
            obj.scheduled_date = scheduleddate;
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

        public string scheduled_date
        {
            get { return data.scheduled_date; }
            set { data.scheduled_date = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string patient_name
        {
            get { return data.patient_name; }
            set { data.patient_name = value; }
        }

        public string gender
        {
            get { return data.gender; }
            set { data.gender = value; }
        }

        public Bloodgroup blood_group
        {
            get { return parseEnum<Bloodgroup>(data.blood_group); }
            set { data.blood_group = value.ToString(); }
        }

        public string dob
        {
            get { return data.dob; }
            set { data.dob = value; }
        }

        public string mobile
        {
            get { return data.mobile; }
            set { data.mobile = value; }
        }

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public string phone
        {
            get { return data.phone; }
            set { data.phone = value; }
        }

        public string medical_department
        {
            get { return data.medical_department; }
            set { data.medical_department = value; }
        }

        public string primary_practitioner
        {
            get { return data.primary_practitioner; }
            set { data.primary_practitioner = value; }
        }

        public string secondary_practitioner
        {
            get { return data.secondary_practitioner; }
            set { data.secondary_practitioner = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string admission_ordered_for
        {
            get { return data.admission_ordered_for; }
            set { data.admission_ordered_for = value; }
        }

        public string admitted_datetime
        {
            get { return data.admitted_datetime; }
            set { data.admitted_datetime = value; }
        }

        private int _expected_length_of_stay = 0;
        public int expected_length_of_stay
        {
            get { return data._expected_length_of_stay; }
            set { data._expected_length_of_stay = value; }
        }

        public string expected_discharge
        {
            get { return data.expected_discharge; }
            set { data.expected_discharge = value; }
        }

        public string admission_practitioner
        {
            get { return data.admission_practitioner; }
            set { data.admission_practitioner = value; }
        }

        public string admission_encounter
        {
            get { return data.admission_encounter; }
            set { data.admission_encounter = value; }
        }

        public string chief_complaint
        {
            get { return data.chief_complaint; }
            set { data.chief_complaint = value; }
        }

        public string admission_instruction
        {
            get { return data.admission_instruction; }
            set { data.admission_instruction = value; }
        }

        public string discharge_practitioner
        {
            get { return data.discharge_practitioner; }
            set { data.discharge_practitioner = value; }
        }

        public string discharge_encounter
        {
            get { return data.discharge_encounter; }
            set { data.discharge_encounter = value; }
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

        public string admission_service_unit_type
        {
            get { return data.admission_service_unit_type; }
            set { data.admission_service_unit_type = value; }
        }

        public string inpatient_occupancies
        {
            get { return data.inpatient_occupancies; }
            set { data.inpatient_occupancies = value; }
        }

        public string discharge_note
        {
            get { return data.discharge_note; }
            set { data.discharge_note = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string diagnosis
        {
            get { return data.diagnosis; }
            set { data.diagnosis = value; }
        }

        public string followup_date
        {
            get { return data.followup_date; }
            set { data.followup_date = value; }
        }

        public string discharge_instructions
        {
            get { return data.discharge_instructions; }
            set { data.discharge_instructions = value; }
        }

        public string discharge_ordered_date
        {
            get { return data.discharge_ordered_date; }
            set { data.discharge_ordered_date = value; }
        }

        public string therapy_plan
        {
            get { return data.therapy_plan; }
            set { data.therapy_plan = value; }
        }

        public string therapies
        {
            get { return data.therapies; }
            set { data.therapies = value; }
        }

        public string discharge_date
        {
            get { return data.discharge_date; }
            set { data.discharge_date = value; }
        }


    }

    //Enums go here
    public enum Bloodgroup
    {
        [Description("A Positive")]
        APositive,
        [Description("A Negative")]
        ANegative,
        [Description("AB Positive")]
        ABPositive,
        [Description("AB Negative")]
        ABNegative,
        [Description("B Positive")]
        BPositive,
        [Description("B Negative")]
        BNegative,
        [Description("O Positive")]
        OPositive,
        [Description("O Negative")]
        ONegative,
    }

    public enum Status
    {
        [Description("Admission Scheduled")]
        AdmissionScheduled,
        [Description("Admitted")]
        Admitted,
        [Description("Discharge Scheduled")]
        DischargeScheduled,
        [Description("Discharged")]
        Discharged,
    }


}