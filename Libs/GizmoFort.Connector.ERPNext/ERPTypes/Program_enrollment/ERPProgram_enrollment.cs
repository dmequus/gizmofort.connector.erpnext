using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment
{
    public class ERPProgram_enrollment : ERPNextObjectBase
    {
        public ERPProgram_enrollment() : this(new ERPObject(DocType.Program_enrollment)) { }
        public ERPProgram_enrollment(ERPObject obj) : base(obj) { }

        public static ERPProgram_enrollment Create(string studentname, string student, string studentcategory, string studentbatchname, string schoolhouse, string program, string academicyear, string academicterm, string enrollmentdate, int boardingstudent, Modeoftransportation modeoftransportation, string vehicleno, string courses, string fees, string amendedfrom, string image)

        {
            ERPProgram_enrollment obj = new ERPProgram_enrollment();
            obj.student_name = studentname;
            obj.student = student;
            obj.student_category = studentcategory;
            obj.student_batch_name = studentbatchname;
            obj.school_house = schoolhouse;
            obj.program = program;
            obj.academic_year = academicyear;
            obj.academic_term = academicterm;
            obj.enrollment_date = enrollmentdate;
            obj.boarding_student = boardingstudent;
            obj.mode_of_transportation = modeoftransportation;
            obj.vehicle_no = vehicleno;
            obj.courses = courses;
            obj.fees = fees;
            obj.amended_from = amendedfrom;
            obj.image = image;
            return obj;
        }

        public string student_name
        {
            get { return data.student_name; }
            set
            {
                data.student_name = value;
                data.name = value;
            }

        }

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
        }

        public string student_category
        {
            get { return data.student_category; }
            set { data.student_category = value; }
        }

        public string student_batch_name
        {
            get { return data.student_batch_name; }
            set { data.student_batch_name = value; }
        }

        public string school_house
        {
            get { return data.school_house; }
            set { data.school_house = value; }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
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

        public string enrollment_date
        {
            get { return data.enrollment_date; }
            set { data.enrollment_date = value; }
        }

        private int _boarding_student = 0;
        public int boarding_student
        {
            get { return data._boarding_student; }
            set { data._boarding_student = value; }
        }

        public Modeoftransportation mode_of_transportation
        {
            get { return parseEnum<Modeoftransportation>(data.mode_of_transportation); }
            set { data.mode_of_transportation = value.ToString(); }
        }

        public string vehicle_no
        {
            get { return data.vehicle_no; }
            set { data.vehicle_no = value; }
        }

        public string courses
        {
            get { return data.courses; }
            set { data.courses = value; }
        }

        public string fees
        {
            get { return data.fees; }
            set { data.fees = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }


    }

    //Enums go here
    public enum Modeoftransportation
    {
        [Description("Walking")]
        Walking,
        [Description("Institute's Bus")]
        InstitutesBus,
        [Description("Public Transport")]
        PublicTransport,
        [Description("Self-Driving Vehicle")]
        SelfDrivingVehicle,
        [Description("Pick/Drop by Guardian")]
        PickDropbyGuardian,
    }


}