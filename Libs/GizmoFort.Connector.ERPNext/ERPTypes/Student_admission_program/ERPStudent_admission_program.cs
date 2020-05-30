using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_admission_program
{
    public class ERPStudent_admission_program : ERPNextObjectBase
    {
        public ERPStudent_admission_program() : this(new ERPObject(DocType.Student_admission_program)) { }
        public ERPStudent_admission_program(ERPObject obj) : base(obj) { }

        public static ERPStudent_admission_program Create(string program, string minimumage, string maximumage, double applicationfee, string applicantnamingseries)

        {
            ERPStudent_admission_program obj = new ERPStudent_admission_program();
            obj.program = program;
            obj.minimum_age = minimumage;
            obj.maximum_age = maximumage;
            obj.application_fee = applicationfee;
            obj.applicant_naming_series = applicantnamingseries;
            return obj;
        }

        public string program
        {
            get { return data.program; }
            set
            {
                data.program = value;
                data.name = value;
            }

        }

        public string minimum_age
        {
            get { return data.minimum_age; }
            set { data.minimum_age = value; }
        }

        public string maximum_age
        {
            get { return data.maximum_age; }
            set { data.maximum_age = value; }
        }

        public double application_fee
        {
            get { return data.application_fee; }
            set { data.application_fee = value; }
        }

        public string applicant_naming_series
        {
            get { return data.applicant_naming_series; }
            set { data.applicant_naming_series = value; }
        }


    }

    //Enums go here

}