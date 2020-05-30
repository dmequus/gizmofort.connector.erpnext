using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient
{
    public class ERPPatient : ERPNextObjectBase
    {
        public ERPPatient() : this(new ERPObject(DocType.Patient)) { }
        public ERPPatient(ERPObject obj) : base(obj) { }

        public static ERPPatient Create(string patientname, string sex, string firstname)

        {
            ERPPatient obj = new ERPPatient();
            obj.patient_name = patientname;
            obj.sex = sex;
            obj.first_name = firstname;
            return obj;
        }

        public string patient_name
        {
            get { return data.patient_name; }
            set
            {
                data.patient_name = value;
                data.name = value;
            }

        }

        public string sex
        {
            get { return data.sex; }
            set { data.sex = value; }
        }

        public string first_name
        {
            get { return data.first_name; }
            set { data.first_name = value; }
        }

        public Inpatientstatus inpatient_status
        {
            get { return parseEnum<Inpatientstatus>(data.inpatient_status); }
            set { data.inpatient_status = value.ToString(); }
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

        public string age_html
        {
            get { return data.age_html; }
            set { data.age_html = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public Reportpreference report_preference
        {
            get { return parseEnum<Reportpreference>(data.report_preference); }
            set { data.report_preference = value.ToString(); }
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

        public string patient_relation
        {
            get { return data.patient_relation; }
            set { data.patient_relation = value; }
        }

        public string allergies
        {
            get { return data.allergies; }
            set { data.allergies = value; }
        }

        public string medication
        {
            get { return data.medication; }
            set { data.medication = value; }
        }

        public string medical_history
        {
            get { return data.medical_history; }
            set { data.medical_history = value; }
        }

        public string surgical_history
        {
            get { return data.surgical_history; }
            set { data.surgical_history = value; }
        }

        public string occupation
        {
            get { return data.occupation; }
            set { data.occupation = value; }
        }

        public Maritalstatus marital_status
        {
            get { return parseEnum<Maritalstatus>(data.marital_status); }
            set { data.marital_status = value.ToString(); }
        }

        public string tobacco_past_use
        {
            get { return data.tobacco_past_use; }
            set { data.tobacco_past_use = value; }
        }

        public string tobacco_current_use
        {
            get { return data.tobacco_current_use; }
            set { data.tobacco_current_use = value; }
        }

        public string alcohol_past_use
        {
            get { return data.alcohol_past_use; }
            set { data.alcohol_past_use = value; }
        }

        public string alcohol_current_use
        {
            get { return data.alcohol_current_use; }
            set { data.alcohol_current_use = value; }
        }

        public string surrounding_factors
        {
            get { return data.surrounding_factors; }
            set { data.surrounding_factors = value; }
        }

        public string other_risk_factors
        {
            get { return data.other_risk_factors; }
            set { data.other_risk_factors = value; }
        }

        public string patient_details
        {
            get { return data.patient_details; }
            set { data.patient_details = value; }
        }

        public string default_currency
        {
            get { return data.default_currency; }
            set { data.default_currency = value; }
        }

        public string last_name
        {
            get { return data.last_name; }
            set { data.last_name = value; }
        }

        public string middle_name
        {
            get { return data.middle_name; }
            set { data.middle_name = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        public string default_price_list
        {
            get { return data.default_price_list; }
            set { data.default_price_list = value; }
        }

        public string language
        {
            get { return data.language; }
            set { data.language = value; }
        }


    }

    //Enums go here
    public enum Inpatientstatus
    {
        [Description("Admission Scheduled")]
        AdmissionScheduled,
        [Description("Admitted")]
        Admitted,
        [Description("Discharge Scheduled")]
        DischargeScheduled,
    }

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
        [Description("Active")]
        Active,
        [Description("Disabled")]
        Disabled,
    }

    public enum Reportpreference
    {
        [Description("Email")]
        Email,
        [Description("Print")]
        Print,
    }

    public enum Maritalstatus
    {
        [Description("Single")]
        Single,
        [Description("Married")]
        Married,
        [Description("Divorced")]
        Divorced,
        [Description("Widow")]
        Widow,
    }


}