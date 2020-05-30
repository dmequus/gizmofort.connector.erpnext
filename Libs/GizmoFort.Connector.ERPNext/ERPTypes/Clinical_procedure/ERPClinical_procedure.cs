using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Clinical_procedure
{
    public class ERPClinical_procedure : ERPNextObjectBase
    {
        public ERPClinical_procedure() : this(new ERPObject(DocType.Clinical_procedure)) { }
        public ERPClinical_procedure(ERPObject obj) : base(obj) { }

        public static ERPClinical_procedure Create(string title, string patient, string proceduretemplate)

        {
            ERPClinical_procedure obj = new ERPClinical_procedure();
            obj.title = title;
            obj.patient = patient;
            obj.procedure_template = proceduretemplate;
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

        public string procedure_template
        {
            get { return data.procedure_template; }
            set { data.procedure_template = value; }
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

        public string prescription
        {
            get { return data.prescription; }
            set { data.prescription = value; }
        }

        public string medical_department
        {
            get { return data.medical_department; }
            set { data.medical_department = value; }
        }

        public string practitioner
        {
            get { return data.practitioner; }
            set { data.practitioner = value; }
        }

        public string service_unit
        {
            get { return data.service_unit; }
            set { data.service_unit = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string start_time
        {
            get { return data.start_time; }
            set { data.start_time = value; }
        }

        public string sample
        {
            get { return data.sample; }
            set { data.sample = value; }
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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private int _consume_stock = 0;
        public int consume_stock
        {
            get { return data._consume_stock; }
            set { data._consume_stock = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        private int _invoice_separately_as_consumables = 0;
        public int invoice_separately_as_consumables
        {
            get { return data._invoice_separately_as_consumables; }
            set { data._invoice_separately_as_consumables = value; }
        }

        private double _consumable_total_amount = 0.0;
        public double consumable_total_amount
        {
            get { return data._consumable_total_amount; }
            set { data._consumable_total_amount = value; }
        }

        public string consumption_details
        {
            get { return data.consumption_details; }
            set { data.consumption_details = value; }
        }

        private int _consumption_invoiced = 0;
        public int consumption_invoiced
        {
            get { return data._consumption_invoiced; }
            set { data._consumption_invoiced = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string patient_name
        {
            get { return data.patient_name; }
            set { data.patient_name = value; }
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
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Cancelled")]
        Cancelled,
        [Description("In Progress")]
        InProgress,
        [Description("Completed")]
        Completed,
        [Description("Pending")]
        Pending,
    }


}