using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_admission
{
    public class ERPStudent_admission : ERPNextObjectBase
    {
        public ERPStudent_admission() : this(new ERPObject(DocType.Student_admission)) { }
        public ERPStudent_admission(ERPObject obj) : base(obj) { }

        public static ERPStudent_admission Create(string title, string route, string applicationformroute, string academicyear, string admissionstartdate, string admissionenddate, int published, string programdetails, string introduction)

        {
            ERPStudent_admission obj = new ERPStudent_admission();
            obj.title = title;
            obj.route = route;
            obj.application_form_route = applicationformroute;
            obj.academic_year = academicyear;
            obj.admission_start_date = admissionstartdate;
            obj.admission_end_date = admissionenddate;
            obj.published = published;
            obj.program_details = programdetails;
            obj.introduction = introduction;
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

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        public string application_form_route
        {
            get { return data.application_form_route; }
            set { data.application_form_route = value; }
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set { data.academic_year = value; }
        }

        public string admission_start_date
        {
            get { return data.admission_start_date; }
            set { data.admission_start_date = value; }
        }

        public string admission_end_date
        {
            get { return data.admission_end_date; }
            set { data.admission_end_date = value; }
        }

        private int _published = 0;
        public int published
        {
            get { return data._published; }
            set { data._published = value; }
        }

        public string program_details
        {
            get { return data.program_details; }
            set { data.program_details = value; }
        }

        public string introduction
        {
            get { return data.introduction; }
            set { data.introduction = value; }
        }


    }

    //Enums go here

}