using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Vital_signs
{
    public class ERPVital_signs : ERPNextObjectBase
    {
        public ERPVital_signs() : this(new ERPObject(DocType.Vital_signs)) { }
        public ERPVital_signs(ERPObject obj) : base(obj) { }

        public static ERPVital_signs Create(string title, string patient, string signsdate, string signstime, string namingseries)

        {
            ERPVital_signs obj = new ERPVital_signs();
            obj.title = title;
            obj.patient = patient;
            obj.signs_date = signsdate;
            obj.signs_time = signstime;
            obj.naming_series = namingseries;
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

        public string signs_date
        {
            get { return data.signs_date; }
            set { data.signs_date = value; }
        }

        public string signs_time
        {
            get { return data.signs_time; }
            set { data.signs_time = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string inpatient_record
        {
            get { return data.inpatient_record; }
            set { data.inpatient_record = value; }
        }

        public string patient_name
        {
            get { return data.patient_name; }
            set { data.patient_name = value; }
        }

        public string appointment
        {
            get { return data.appointment; }
            set { data.appointment = value; }
        }

        public string encounter
        {
            get { return data.encounter; }
            set { data.encounter = value; }
        }

        public string temperature
        {
            get { return data.temperature; }
            set { data.temperature = value; }
        }

        public string pulse
        {
            get { return data.pulse; }
            set { data.pulse = value; }
        }

        public string respiratory_rate
        {
            get { return data.respiratory_rate; }
            set { data.respiratory_rate = value; }
        }

        public Tongue tongue
        {
            get { return parseEnum<Tongue>(data.tongue); }
            set { data.tongue = value.ToString(); }
        }

        public Abdomen abdomen
        {
            get { return parseEnum<Abdomen>(data.abdomen); }
            set { data.abdomen = value.ToString(); }
        }

        public Reflexes reflexes
        {
            get { return parseEnum<Reflexes>(data.reflexes); }
            set { data.reflexes = value.ToString(); }
        }

        public string bp_systolic
        {
            get { return data.bp_systolic; }
            set { data.bp_systolic = value; }
        }

        public string bp_diastolic
        {
            get { return data.bp_diastolic; }
            set { data.bp_diastolic = value; }
        }

        public string bp
        {
            get { return data.bp; }
            set { data.bp = value; }
        }

        public string vital_signs_note
        {
            get { return data.vital_signs_note; }
            set { data.vital_signs_note = value; }
        }

        private double _height = 0.0;
        public double height
        {
            get { return data._height; }
            set { data._height = value; }
        }

        private double _weight = 0.0;
        public double weight
        {
            get { return data._weight; }
            set { data._weight = value; }
        }

        private double _bmi = 0.0;
        public double bmi
        {
            get { return data._bmi; }
            set { data._bmi = value; }
        }

        public string nutrition_note
        {
            get { return data.nutrition_note; }
            set { data.nutrition_note = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Tongue
    {
        [Description("Coated")]
        Coated,
        [Description("Very Coated")]
        VeryCoated,
        [Description("Normal")]
        Normal,
        [Description("Furry")]
        Furry,
        [Description("Cuts")]
        Cuts,
    }

    public enum Abdomen
    {
        [Description("Normal")]
        Normal,
        [Description("Bloated")]
        Bloated,
        [Description("Full")]
        Full,
        [Description("Fluid")]
        Fluid,
        [Description("Constipated")]
        Constipated,
    }

    public enum Reflexes
    {
        [Description("Normal")]
        Normal,
        [Description("Hyper")]
        Hyper,
        [Description("Very Hyper")]
        VeryHyper,
        [Description("One Sided")]
        OneSided,
    }


}