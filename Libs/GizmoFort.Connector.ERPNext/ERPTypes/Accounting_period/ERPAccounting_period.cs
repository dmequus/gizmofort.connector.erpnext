using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounting_period
{
    public class ERPAccounting_period : ERPNextObjectBase
    {
        public ERPAccounting_period() : this(new ERPObject(DocType.Accounting_period)) { }
        public ERPAccounting_period(ERPObject obj) : base(obj) { }

        public static ERPAccounting_period Create(string periodname, string startdate, string enddate, string company, string closeddocuments)

        {
            ERPAccounting_period obj = new ERPAccounting_period();
            obj.period_name = periodname;
            obj.start_date = startdate;
            obj.end_date = enddate;
            obj.company = company;
            obj.closed_documents = closeddocuments;
            return obj;
        }

        public string period_name
        {
            get { return data.period_name; }
            set
            {
                data.period_name = value;
                data.name = value;
            }

        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string closed_documents
        {
            get { return data.closed_documents; }
            set { data.closed_documents = value; }
        }


    }

    //Enums go here

}