using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test
{
    public class ERPLab_test : ERPNextObjectBase
    {
        public ERPLab_test() : this(new ERPObject(DocType.Lab_test)) { }
        public ERPLab_test(ERPObject obj) : base(obj) { }

        public static ERPLab_test Create(string patient, string namingseries, string patientsex, string template)

        {
            ERPLab_test obj = new ERPLab_test();
            obj.patient = patient;
            obj.naming_series = namingseries;
            obj.patient_sex = patientsex;
            obj.template = template;
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

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string patient_sex
        {
            get { return data.patient_sex; }
            set { data.patient_sex = value; }
        }

        public string template
        {
            get { return data.template; }
            set { data.template = value; }
        }

        public string inpatient_record
        {
            get { return data.inpatient_record; }
            set { data.inpatient_record = value; }
        }

        private int _invoiced = 0;
        public int invoiced
        {
            get { return data._invoiced; }
            set { data._invoiced = value; }
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

        public string practitioner
        {
            get { return data.practitioner; }
            set { data.practitioner = value; }
        }

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public string mobile
        {
            get { return data.mobile; }
            set { data.mobile = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string submitted_date
        {
            get { return data.submitted_date; }
            set { data.submitted_date = value; }
        }

        public string approved_date
        {
            get { return data.approved_date; }
            set { data.approved_date = value; }
        }

        public string sample
        {
            get { return data.sample; }
            set { data.sample = value; }
        }

        public string result_date
        {
            get { return data.result_date; }
            set { data.result_date = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        public string employee_designation
        {
            get { return data.employee_designation; }
            set { data.employee_designation = value; }
        }

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }

        public string report_preference
        {
            get { return data.report_preference; }
            set { data.report_preference = value; }
        }

        public string lab_test_name
        {
            get { return data.lab_test_name; }
            set { data.lab_test_name = value; }
        }

        public string lab_test_group
        {
            get { return data.lab_test_group; }
            set { data.lab_test_group = value; }
        }

        public string normal_test_items
        {
            get { return data.normal_test_items; }
            set { data.normal_test_items = value; }
        }

        public string special_test_items
        {
            get { return data.special_test_items; }
            set { data.special_test_items = value; }
        }

        public string sensitivity_test_items
        {
            get { return data.sensitivity_test_items; }
            set { data.sensitivity_test_items = value; }
        }

        public string lab_test_comment
        {
            get { return data.lab_test_comment; }
            set { data.lab_test_comment = value; }
        }

        public string custom_result
        {
            get { return data.custom_result; }
            set { data.custom_result = value; }
        }

        private int _email_sent = 0;
        public int email_sent
        {
            get { return data._email_sent; }
            set { data._email_sent = value; }
        }

        private int _sms_sent = 0;
        public int sms_sent
        {
            get { return data._sms_sent; }
            set { data._sms_sent = value; }
        }

        private int _printed = 0;
        public int printed
        {
            get { return data._printed; }
            set { data._printed = value; }
        }

        private int _normal_toggle = 0;
        public int normal_toggle
        {
            get { return data._normal_toggle; }
            set { data._normal_toggle = value; }
        }

        private int _special_toggle = 0;
        public int special_toggle
        {
            get { return data._special_toggle; }
            set { data._special_toggle = value; }
        }

        private int _sensitivity_toggle = 0;
        public int sensitivity_toggle
        {
            get { return data._sensitivity_toggle; }
            set { data._sensitivity_toggle = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string prescription
        {
            get { return data.prescription; }
            set { data.prescription = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Completed")]
        Completed,
        [Description("Approved")]
        Approved,
        [Description("Rejected")]
        Rejected,
        [Description("Cancelled")]
        Cancelled,
    }


}