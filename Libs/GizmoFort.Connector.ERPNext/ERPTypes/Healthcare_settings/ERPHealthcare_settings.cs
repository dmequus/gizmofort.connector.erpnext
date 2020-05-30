using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_settings
{
    public class ERPHealthcare_settings : ERPNextObjectBase
    {
        public ERPHealthcare_settings() : this(new ERPObject(DocType.Healthcare_settings)) { }
        public ERPHealthcare_settings(ERPObject obj) : base(obj) { }

        public static ERPHealthcare_settings Create()

        {
            ERPHealthcare_settings obj = new ERPHealthcare_settings();
            return obj;
        }

        public string default_medical_code_standard
        {
            get { return data.default_medical_code_standard; }
            set
            {
                data.default_medical_code_standard = value;
                data.name = value;
            }

        }

        public long collect_registration_fee
        {
            get { return data.collect_registration_fee; }
            set { data.collect_registration_fee = value; }
        }

        public double registration_fee
        {
            get { return data.registration_fee; }
            set { data.registration_fee = value; }
        }

        public int valid_days
        {
            get { return data.valid_days; }
            set { data.valid_days = value; }
        }

        public string inpatient_visit_charge_item
        {
            get { return data.inpatient_visit_charge_item; }
            set { data.inpatient_visit_charge_item = value; }
        }

        public string op_consulting_charge_item
        {
            get { return data.op_consulting_charge_item; }
            set { data.op_consulting_charge_item = value; }
        }

        public string clinical_procedure_consumable_item
        {
            get { return data.clinical_procedure_consumable_item; }
            set { data.clinical_procedure_consumable_item = value; }
        }

        public string income_account
        {
            get { return data.income_account; }
            set { data.income_account = value; }
        }

        public string receivable_account
        {
            get { return data.receivable_account; }
            set { data.receivable_account = value; }
        }

        public long employee_name_and_designation_in_print
        {
            get { return data.employee_name_and_designation_in_print; }
            set { data.employee_name_and_designation_in_print = value; }
        }

        public string custom_signature_in_print
        {
            get { return data.custom_signature_in_print; }
            set { data.custom_signature_in_print = value; }
        }

        public string sms_printed
        {
            get { return data.sms_printed; }
            set { data.sms_printed = value; }
        }

        public string sms_emailed
        {
            get { return data.sms_emailed; }
            set { data.sms_emailed = value; }
        }

        public long lab_test_approval_required
        {
            get { return data.lab_test_approval_required; }
            set { data.lab_test_approval_required = value; }
        }

        public long link_customer_to_patient
        {
            get { return data.link_customer_to_patient; }
            set { data.link_customer_to_patient = value; }
        }

        public long create_lab_test_on_si_submit
        {
            get { return data.create_lab_test_on_si_submit; }
            set { data.create_lab_test_on_si_submit = value; }
        }

        public long create_sample_collection_for_lab_test
        {
            get { return data.create_sample_collection_for_lab_test; }
            set { data.create_sample_collection_for_lab_test = value; }
        }

        public Patientnameby patient_name_by
        {
            get { return parseEnum<Patientnameby>(data.patient_name_by); }
            set { data.patient_name_by = value.ToString(); }
        }

        public long automate_appointment_invoicing
        {
            get { return data.automate_appointment_invoicing; }
            set { data.automate_appointment_invoicing = value; }
        }

        public long send_registration_msg
        {
            get { return data.send_registration_msg; }
            set { data.send_registration_msg = value; }
        }

        public string registration_msg
        {
            get { return data.registration_msg; }
            set { data.registration_msg = value; }
        }

        public long send_appointment_confirmation
        {
            get { return data.send_appointment_confirmation; }
            set { data.send_appointment_confirmation = value; }
        }

        public string appointment_confirmation_msg
        {
            get { return data.appointment_confirmation_msg; }
            set { data.appointment_confirmation_msg = value; }
        }

        public long avoid_confirmation
        {
            get { return data.avoid_confirmation; }
            set { data.avoid_confirmation = value; }
        }

        public long send_appointment_reminder
        {
            get { return data.send_appointment_reminder; }
            set { data.send_appointment_reminder = value; }
        }

        public string appointment_reminder_msg
        {
            get { return data.appointment_reminder_msg; }
            set { data.appointment_reminder_msg = value; }
        }

        public string remind_before
        {
            get { return data.remind_before; }
            set { data.remind_before = value; }
        }

        public int max_visits
        {
            get { return data.max_visits; }
            set { data.max_visits = value; }
        }

        public long enable_free_follow_ups
        {
            get { return data.enable_free_follow_ups; }
            set { data.enable_free_follow_ups = value; }
        }


    }

    //Enums go here
    public enum Patientnameby
    {
        [Description("Patient Name")]
        PatientName,
        [Description("Naming Series")]
        NamingSeries,
    }


}