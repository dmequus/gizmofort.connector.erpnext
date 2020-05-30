using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student
{
    public class ERPStudent : ERPNextObjectBase
    {
        public ERPStudent() : this(new ERPObject(DocType.Student)) { }
        public ERPStudent(ERPObject obj) : base(obj) { }

        public static ERPStudent Create(string title, int enabled, string firstname, string middlename, string lastname, string user, string namingseries, string studentemailid, string studentmobilenumber, string joiningdate, string image, string dateofbirth, Bloodgroup bloodgroup, Gender gender, string nationality, string studentapplicant, string addressline1, string addressline2, string pincode, string city, string state, string guardians, string siblings, string dateofleaving, string leavingcertificatenumber, string reasonforleaving)

        {
            ERPStudent obj = new ERPStudent();
            obj.title = title;
            obj.enabled = enabled;
            obj.first_name = firstname;
            obj.middle_name = middlename;
            obj.last_name = lastname;
            obj.user = user;
            obj.naming_series = namingseries;
            obj.student_email_id = studentemailid;
            obj.student_mobile_number = studentmobilenumber;
            obj.joining_date = joiningdate;
            obj.image = image;
            obj.date_of_birth = dateofbirth;
            obj.blood_group = bloodgroup;
            obj.gender = gender;
            obj.nationality = nationality;
            obj.student_applicant = studentapplicant;
            obj.address_line_1 = addressline1;
            obj.address_line_2 = addressline2;
            obj.pincode = pincode;
            obj.city = city;
            obj.state = state;
            obj.guardians = guardians;
            obj.siblings = siblings;
            obj.date_of_leaving = dateofleaving;
            obj.leaving_certificate_number = leavingcertificatenumber;
            obj.reason_for_leaving = reasonforleaving;
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

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
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

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
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

        public string joining_date
        {
            get { return data.joining_date; }
            set { data.joining_date = value; }
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

        public Bloodgroup blood_group
        {
            get { return parseEnum<Bloodgroup>(data.blood_group); }
            set { data.blood_group = value.ToString(); }
        }

        public Gender gender
        {
            get { return parseEnum<Gender>(data.gender); }
            set { data.gender = value.ToString(); }
        }

        public string nationality
        {
            get { return data.nationality; }
            set { data.nationality = value; }
        }

        public string student_applicant
        {
            get { return data.student_applicant; }
            set { data.student_applicant = value; }
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

        public string date_of_leaving
        {
            get { return data.date_of_leaving; }
            set { data.date_of_leaving = value; }
        }

        public string leaving_certificate_number
        {
            get { return data.leaving_certificate_number; }
            set { data.leaving_certificate_number = value; }
        }

        public string reason_for_leaving
        {
            get { return data.reason_for_leaving; }
            set { data.reason_for_leaving = value; }
        }


    }

    //Enums go here
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

    public enum Gender
    {
        [Description("Male")]
        Male,
        [Description("Female")]
        Female,
        [Description("Other")]
        Other,
    }


}