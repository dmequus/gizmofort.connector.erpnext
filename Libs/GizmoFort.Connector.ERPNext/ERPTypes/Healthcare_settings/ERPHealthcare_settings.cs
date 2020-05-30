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

        private int _collect_registration_fee = 0;
        public int collect_registration_fee
        {
            get { return data._collect_registration_fee; }
            set { data._collect_registration_fee = value; }
        }

        private double _registration_fee = 0.0;
        public double registration_fee
        {
            get { return data._registration_fee; }
            set { data._registration_fee = value; }
        }

        private int _valid_days = 0;
        public int valid_days
        {
            get { return data._valid_days; }
            set { data._valid_days = value; }
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

        private int _employee_name_and_designation_in_print = 0;
        public int employee_name_and_designation_in_print
        {
            get { return data._employee_name_and_designation_in_print; }
            set { data._employee_name_and_designation_in_print = value; }
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

        private int _lab_test_approval_required = 0;
        public int lab_test_approval_required
        {
            get { return data._lab_test_approval_required; }
            set { data._lab_test_approval_required = value; }
        }

        private int _link_customer_to_patient = 0;
        public int link_customer_to_patient
        {
            get { return data._link_customer_to_patient; }
            set { data._link_customer_to_patient = value; }
        }

        private int _create_lab_test_on_si_submit = 0;
        public int create_lab_test_on_si_submit
        {
            get { return data._create_lab_test_on_si_submit; }
            set { data._create_lab_test_on_si_submit = value; }
        }

        private int _create_sample_collection_for_lab_test = 0;
        public int create_sample_collection_for_lab_test
        {
            get { return data._create_sample_collection_for_lab_test; }
            set { data._create_sample_collection_for_lab_test = value; }
        }

        public Patientnameby patient_name_by
        {
            get { return parseEnum<Patientnameby>(data.patient_name_by); }
            set { data.patient_name_by = value.ToString(); }
        }

        private int _automate_appointment_invoicing = 0;
        public int automate_appointment_invoicing
        {
            get { return data._automate_appointment_invoicing; }
            set { data._automate_appointment_invoicing = value; }
        }

        private int _send_registration_msg = 0;
        public int send_registration_msg
        {
            get { return data._send_registration_msg; }
            set { data._send_registration_msg = value; }
        }

        public string registration_msg
        {
            get { return data.registration_msg; }
            set { data.registration_msg = value; }
        }

        private int _send_appointment_confirmation = 0;
        public int send_appointment_confirmation
        {
            get { return data._send_appointment_confirmation; }
            set { data._send_appointment_confirmation = value; }
        }

        public string appointment_confirmation_msg
        {
            get { return data.appointment_confirmation_msg; }
            set { data.appointment_confirmation_msg = value; }
        }

        private int _avoid_confirmation = 0;
        public int avoid_confirmation
        {
            get { return data._avoid_confirmation; }
            set { data._avoid_confirmation = value; }
        }

        private int _send_appointment_reminder = 0;
        public int send_appointment_reminder
        {
            get { return data._send_appointment_reminder; }
            set { data._send_appointment_reminder = value; }
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

        private int _max_visits = 0;
        public int max_visits
        {
            get { return data._max_visits; }
            set { data._max_visits = value; }
        }

        private int _enable_free_follow_ups = 0;
        public int enable_free_follow_ups
        {
            get { return data._enable_free_follow_ups; }
            set { data._enable_free_follow_ups = value; }
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