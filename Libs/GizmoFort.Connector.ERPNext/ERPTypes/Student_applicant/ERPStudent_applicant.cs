using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_applicant
{
    public class ERPStudent_applicant : ERPNextObjectBase
    {
        public ERPStudent_applicant() : this(new ERPObject(DocType.Student_applicant)) { }
        public ERPStudent_applicant(ERPObject obj) : base(obj) { }

        public static ERPStudent_applicant Create(string title, string firstname, string middlename, string lastname, string program, int lmsonly, int paid, string namingseries, Applicationstatus applicationstatus, string applicationdate, string academicyear, string academicterm, string studentadmission, string image, string dateofbirth, Gender gender, Bloodgroup bloodgroup, string studentemailid, string studentmobilenumber, string nationality, string addressline1, string addressline2, string pincode, string city, string state, string guardians, string siblings, string amendedfrom)

        {
            ERPStudent_applicant obj = new ERPStudent_applicant();
            obj.title = title;
            obj.first_name = firstname;
            obj.middle_name = middlename;
            obj.last_name = lastname;
            obj.program = program;
            obj.lms_only = lmsonly;
            obj.paid = paid;
            obj.naming_series = namingseries;
            obj.application_status = applicationstatus;
            obj.application_date = applicationdate;
            obj.academic_year = academicyear;
            obj.academic_term = academicterm;
            obj.student_admission = studentadmission;
            obj.image = image;
            obj.date_of_birth = dateofbirth;
            obj.gender = gender;
            obj.blood_group = bloodgroup;
            obj.student_email_id = studentemailid;
            obj.student_mobile_number = studentmobilenumber;
            obj.nationality = nationality;
            obj.address_line_1 = addressline1;
            obj.address_line_2 = addressline2;
            obj.pincode = pincode;
            obj.city = city;
            obj.state = state;
            obj.guardians = guardians;
            obj.siblings = siblings;
            obj.amended_from = amendedfrom;
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

        public string first_name
        {
            get { return data.first_name; }
            set { data.first_name = value; }
        }

        public string middle_name
        {
            get { return data.middle_name; }
            set { data.middle_name = value; }
        }

        public string last_name
        {
            get { return data.last_name; }
            set { data.last_name = value; }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
        }

        private int _lms_only = 0;
        public int lms_only
        {
            get { return data._lms_only; }
            set { data._lms_only = value; }
        }

        private int _paid = 0;
        public int paid
        {
            get { return data._paid; }
            set { data._paid = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public Applicationstatus application_status
        {
            get { return parseEnum<Applicationstatus>(data.application_status); }
            set { data.application_status = value.ToString(); }
        }

        public string application_date
        {
            get { return data.application_date; }
            set { data.application_date = value; }
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set { data.academic_year = value; }
        }

        public string academic_term
        {
            get { return data.academic_term; }
            set { data.academic_term = value; }
        }

        public string student_admission
        {
            get { return data.student_admission; }
            set { data.student_admission = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string date_of_birth
        {
            get { return data.date_of_birth; }
            set { data.date_of_birth = value; }
        }

        public Gender gender
        {
            get { return parseEnum<Gender>(data.gender); }
            set { data.gender = value.ToString(); }
        }

        public Bloodgroup blood_group
        {
            get { return parseEnum<Bloodgroup>(data.blood_group); }
            set { data.blood_group = value.ToString(); }
        }

        public string student_email_id
        {
            get { return data.student_email_id; }
            set { data.student_email_id = value; }
        }

        public string student_mobile_number
        {
            get { return data.student_mobile_number; }
            set { data.student_mobile_number = value; }
        }

        public string nationality
        {
            get { return data.nationality; }
            set { data.nationality = value; }
        }

        public string address_line_1
        {
            get { return data.address_line_1; }
            set { data.address_line_1 = value; }
        }

        public string address_line_2
        {
            get { return data.address_line_2; }
            set { data.address_line_2 = value; }
        }

        public string pincode
        {
            get { return data.pincode; }
            set { data.pincode = value; }
        }

        public string city
        {
            get { return data.city; }
            set { data.city = value; }
        }

        public string state
        {
            get { return data.state; }
            set { data.state = value; }
        }

        public string guardians
        {
            get { return data.guardians; }
            set { data.guardians = value; }
        }

        public string siblings
        {
            get { return data.siblings; }
            set { data.siblings = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Applicationstatus
    {
        [Description("Applied")]
        Applied,
        [Description("Approved")]
        Approved,
        [Description("Rejected")]
        Rejected,
        [Description("Admitted")]
        Admitted,
    }

    public enum Gender
    {
        [Description("Male")]
        Male,
        [Description("Female")]
        Female,
    }

    public enum Bloodgroup
    {
        [Description("A+")]
        APos,
        [Description("A-")]
        ANeg,
        [Description("B+")]
        BPos,
        [Description("B-")]
        BNeg,
        [Description("O+")]
        OPos,
        [Description("O-")]
        ONeg,
        [Description("AB+")]
        ABPos,
        [Description("AB-")]
        ABNeg,
    }


}