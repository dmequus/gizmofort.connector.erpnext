using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Education_settings
{
    public class ERPEducation_settings : ERPNextObjectBase
    {
        public ERPEducation_settings() : this(new ERPObject(DocType.Education_settings)) { }
        public ERPEducation_settings(ERPObject obj) : base(obj) { }

        public static ERPEducation_settings Create()

        {
            ERPEducation_settings obj = new ERPEducation_settings();
            return obj;
        }

        public string current_academic_year
        {
            get { return data.current_academic_year; }
            set
            {
                data.current_academic_year = value;
                data.name = value;
            }

        }

        public string current_academic_term
        {
            get { return data.current_academic_term; }
            set { data.current_academic_term = value; }
        }

        public string attendance_freeze_date
        {
            get { return data.attendance_freeze_date; }
            set { data.attendance_freeze_date = value; }
        }

        public long validate_batch
        {
            get { return data.validate_batch; }
            set { data.validate_batch = value; }
        }

        public long validate_course
        {
            get { return data.validate_course; }
            set { data.validate_course = value; }
        }

        public long academic_term_reqd
        {
            get { return data.academic_term_reqd; }
            set { data.academic_term_reqd = value; }
        }

        public Instructorcreatedby instructor_created_by
        {
            get { return parseEnum<Instructorcreatedby>(data.instructor_created_by); }
            set { data.instructor_created_by = value.ToString(); }
        }

        public string portal_title
        {
            get { return data.portal_title; }
            set { data.portal_title = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public long enable_lms
        {
            get { return data.enable_lms; }
            set { data.enable_lms = value; }
        }

        public long user_creation_skip
        {
            get { return data.user_creation_skip; }
            set { data.user_creation_skip = value; }
        }


    }

    //Enums go here
    public enum Instructorcreatedby
    {
        [Description("Full Name")]
        FullName,
        [Description("Naming Series")]
        NamingSeries,
        [Description("Employee Number")]
        EmployeeNumber,
    }


}