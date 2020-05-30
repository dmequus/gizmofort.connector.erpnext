using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Therapy_session
{
    public class ERPTherapy_session : ERPNextObjectBase
    {
        public ERPTherapy_session() : this(new ERPObject(DocType.Therapy_session)) { }
        public ERPTherapy_session(ERPObject obj) : base(obj) { }

        public static ERPTherapy_session Create(string patient, string therapytype, string therapyplan, string company)

        {
            ERPTherapy_session obj = new ERPTherapy_session();
            obj.patient = patient;
            obj.therapy_type = therapytype;
            obj.therapy_plan = therapyplan;
            obj.company = company;
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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
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

        public string gender
        {
            get { return data.gender; }
            set { data.gender = value; }
        }

        public string practitioner
        {
            get { return data.practitioner; }
            set { data.practitioner = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        private int _duration = 0;
        public int duration
        {
            get { return data._duration; }
            set { data._duration = value; }
        }

        public Location location
        {
            get { return parseEnum<Location>(data.location); }
            set { data.location = value.ToString(); }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        public string exercises
        {
            get { return data.exercises; }
            set { data.exercises = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string service_unit
        {
            get { return data.service_unit; }
            set { data.service_unit = value; }
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

        private int _invoiced = 0;
        public int invoiced
        {
            get { return data._invoiced; }
            set { data._invoiced = value; }
        }

        public string patient_age
        {
            get { return data.patient_age; }
            set { data.patient_age = value; }
        }

        private int _total_counts_targeted = 0;
        public int total_counts_targeted
        {
            get { return data._total_counts_targeted; }
            set { data._total_counts_targeted = value; }
        }

        private int _total_counts_completed = 0;
        public int total_counts_completed
        {
            get { return data._total_counts_completed; }
            set { data._total_counts_completed = value; }
        }

        public string patient_name
        {
            get { return data.patient_name; }
            set { data.patient_name = value; }
        }


    }

    //Enums go here
    public enum Location
    {
        [Description("Center")]
        Center,
        [Description("Home")]
        Home,
        [Description("Tele")]
        Tele,
    }


}