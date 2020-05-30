using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fiscal_year
{
    public class ERPFiscal_year : ERPNextObjectBase
    {
        public ERPFiscal_year() : this(new ERPObject(DocType.Fiscal_year)) { }
        public ERPFiscal_year(ERPObject obj) : base(obj) { }

        public static ERPFiscal_year Create(string year, long disabled, string yearstartdate, string yearenddate, string companies, long autocreated)

        {
            ERPFiscal_year obj = new ERPFiscal_year();
            obj.year = year;
            obj.disabled = disabled;
            obj.year_start_date = yearstartdate;
            obj.year_end_date = yearenddate;
            obj.companies = companies;
            obj.auto_created = autocreated;
            return obj;
        }

        public string year
        {
            get { return data.year; }
            set
            {
                data.year = value;
                data.name = value;
            }

        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
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

        public string companies
        {
            get { return data.companies; }
            set { data.companies = value; }
        }

        public long auto_created
        {
            get { return data.auto_created; }
            set { data.auto_created = value; }
        }


    }

    //Enums go here

}