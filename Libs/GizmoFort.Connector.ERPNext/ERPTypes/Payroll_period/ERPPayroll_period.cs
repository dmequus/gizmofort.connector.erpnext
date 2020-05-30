using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payroll_period
{
    public class ERPPayroll_period : ERPNextObjectBase
    {
        public ERPPayroll_period() : this(new ERPObject(DocType.Payroll_period)) { }
        public ERPPayroll_period(ERPObject obj) : base(obj) { }

        public static ERPPayroll_period Create(string company, string startdate, string enddate)

        {
            ERPPayroll_period obj = new ERPPayroll_period();
            obj.company = company;
            obj.start_date = startdate;
            obj.end_date = enddate;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
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

        public string periods
        {
            get { return data.periods; }
            set { data.periods = value; }
        }


    }

    //Enums go here

}