using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Academic_year
{
    public class ERPAcademic_year : ERPNextObjectBase
    {
        public ERPAcademic_year() : this(new ERPObject(DocType.Academic_year)) { }
        public ERPAcademic_year(ERPObject obj) : base(obj) { }

        public static ERPAcademic_year Create(string academicyearname, string yearstartdate, string yearenddate)

        {
            ERPAcademic_year obj = new ERPAcademic_year();
            obj.academic_year_name = academicyearname;
            obj.year_start_date = yearstartdate;
            obj.year_end_date = yearenddate;
            return obj;
        }

        public string academic_year_name
        {
            get { return data.academic_year_name; }
            set
            {
                data.academic_year_name = value;
                data.name = value;
            }

        }

        public string year_start_date
        {
            get { return data.year_start_date; }
            set { data.year_start_date = value; }
        }

        public string year_end_date
        {
            get { return data.year_end_date; }
            set { data.year_end_date = value; }
        }


    }

    //Enums go here

}