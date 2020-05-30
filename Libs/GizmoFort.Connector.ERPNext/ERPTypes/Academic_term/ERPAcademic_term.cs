using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Academic_term
{
    public class ERPAcademic_term : ERPNextObjectBase
    {
        public ERPAcademic_term() : this(new ERPObject(DocType.Academic_term)) { }
        public ERPAcademic_term(ERPObject obj) : base(obj) { }

        public static ERPAcademic_term Create(string title, string academicyear, string termname, string termstartdate, string termenddate)

        {
            ERPAcademic_term obj = new ERPAcademic_term();
            obj.title = title;
            obj.academic_year = academicyear;
            obj.term_name = termname;
            obj.term_start_date = termstartdate;
            obj.term_end_date = termenddate;
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

        public string academic_year
        {
            get { return data.academic_year; }
            set { data.academic_year = value; }
        }

        public string term_name
        {
            get { return data.term_name; }
            set { data.term_name = value; }
        }

        public string term_start_date
        {
            get { return data.term_start_date; }
            set { data.term_start_date = value; }
        }

        public string term_end_date
        {
            get { return data.term_end_date; }
            set { data.term_end_date = value; }
        }


    }

    //Enums go here

}