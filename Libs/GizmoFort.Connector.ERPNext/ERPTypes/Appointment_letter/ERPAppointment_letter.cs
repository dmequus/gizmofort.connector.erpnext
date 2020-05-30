using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_letter
{
    public class ERPAppointment_letter : ERPNextObjectBase
    {
        public ERPAppointment_letter() : this(new ERPObject(DocType.Appointment_letter)) { }
        public ERPAppointment_letter(ERPObject obj) : base(obj) { }

        public static ERPAppointment_letter Create(string applicantname, string appointmentdate, string appointmentlettertemplate, string introduction, string jobapplicant, string company, string terms)

        {
            ERPAppointment_letter obj = new ERPAppointment_letter();
            obj.applicant_name = applicantname;
            obj.appointment_date = appointmentdate;
            obj.appointment_letter_template = appointmentlettertemplate;
            obj.introduction = introduction;
            obj.job_applicant = jobapplicant;
            obj.company = company;
            obj.terms = terms;
            return obj;
        }

        public string applicant_name
        {
            get { return data.applicant_name; }
            set
            {
                data.applicant_name = value;
                data.name = value;
            }

        }

        public string appointment_date
        {
            get { return data.appointment_date; }
            set { data.appointment_date = value; }
        }

        public string appointment_letter_template
        {
            get { return data.appointment_letter_template; }
            set { data.appointment_letter_template = value; }
        }

        public string introduction
        {
            get { return data.introduction; }
            set { data.introduction = value; }
        }

        public string job_applicant
        {
            get { return data.job_applicant; }
            set { data.job_applicant = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        public string closing_notes
        {
            get { return data.closing_notes; }
            set { data.closing_notes = value; }
        }


    }

    //Enums go here

}