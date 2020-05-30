using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_appointment
{
    public class ERPPatient_appointment : ERPNextObjectBase
    {
        public ERPPatient_appointment() : this(new ERPObject(DocType.Patient_appointment)) { }
        public ERPPatient_appointment(ERPObject obj) : base(obj) { }

        public static ERPPatient_appointment Create(string title, string patient, string practitioner, string appointmentdate, string appointmenttime, string company)

        {
            ERPPatient_appointment obj = new ERPPatient_appointment();
            obj.title = title;
            obj.patient = patient;
            obj.practitioner = practitioner;
            obj.appointment_date = appointmentdate;
            obj.appointment_time = appointmenttime;
            obj.company = company;
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

        public string appointment_date
        {
            get { return data.appointment_date; }
            set { data.appointment_date = value; }
        }

        public string appointment_time
        {
            get { return data.appointment_time; }
            set { data.appointment_time = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string inpatient_record
        {
            get { return data.inpatient_record; }
            set { data.inpatient_record = value; }
        }

        public string appointment_type
        {
            get { return data.appointment_type; }
            set { data.appointment_type = value; }
        }

        private int _duration = 0;
        public int duration
        {
            get { return data._duration; }
            set { data._duration = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string procedure_template
        {
            get { return data.procedure_template; }
            set { data.procedure_template = value; }
        }

        public string procedure_prescription
        {
            get { return data.procedure_prescription; }
            set { data.procedure_prescription = value; }
        }

        public string service_unit
        {
            get { return data.service_unit; }
            set { data.service_unit = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string patient_name
        {
            get { return data.patient_name; }
            set { data.patient_name = value; }
        }

        public string patient_sex
        {
            get { return data.patient_sex; }
            set { data.patient_sex = value; }
        }

        public string patient_age
        {
            get { return data.patient_age; }
            set { data.patient_age = value; }
        }

        public string appointment_datetime
        {
            get { return data.appointment_datetime; }
            set { data.appointment_datetime = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        private double _paid_amount = 0.0;
        public double paid_amount
        {
            get { return data._paid_amount; }
            set { data._paid_amount = value; }
        }

        private int _invoiced = 0;
        public int invoiced
        {
            get { return data._invoiced; }
            set { data._invoiced = value; }
        }

        public string notes
        {
            get { return data.notes; }
            set { data.notes = value; }
        }

        public string referring_practitioner
        {
            get { return data.referring_practitioner; }
            set { data.referring_practitioner = value; }
        }

        private int _reminded = 0;
        public int reminded
        {
            get { return data._reminded; }
            set { data._reminded = value; }
        }

        public string therapy_type
        {
            get { return data.therapy_type; }
            set { data.therapy_type = value; }
        }

        public string therapy_plan
        {
            get { return data.therapy_plan; }
            set { data.therapy_plan = value; }
        }

        public string ref_sales_invoice
        {
            get { return data.ref_sales_invoice; }
            set { data.ref_sales_invoice = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string billing_item
        {
            get { return data.billing_item; }
            set { data.billing_item = value; }
        }

        public string practitioner_name
        {
            get { return data.practitioner_name; }
            set { data.practitioner_name = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Scheduled")]
        Scheduled,
        [Description("Open")]
        Open,
        [Description("Closed")]
        Closed,
        [Description("Cancelled")]
        Cancelled,
    }


}