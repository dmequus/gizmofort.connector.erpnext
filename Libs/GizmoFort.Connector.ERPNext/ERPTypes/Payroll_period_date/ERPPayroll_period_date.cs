using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payroll_period_date
{
    public class ERPPayroll_period_date : ERPNextObjectBase
    {
        public ERPPayroll_period_date() : this(new ERPObject(DocType.Payroll_period_date)) { }
        public ERPPayroll_period_date(ERPObject obj) : base(obj) { }

        public static ERPPayroll_period_date Create(string startdate, string enddate)

        {
            ERPPayroll_period_date obj = new ERPPayroll_period_date();
            obj.start_date = startdate;
            obj.end_date = enddate;
            return obj;
        }

        public string start_date
        {
            get { return data.start_date; }
            set
            {
                data.start_date = value;
                data.name = value;
            }

        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }


    }

    //Enums go here

}