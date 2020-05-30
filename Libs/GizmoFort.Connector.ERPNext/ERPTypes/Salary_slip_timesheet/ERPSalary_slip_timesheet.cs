using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_slip_timesheet
{
    public class ERPSalary_slip_timesheet : ERPNextObjectBase
    {
        public ERPSalary_slip_timesheet() : this(new ERPObject(DocType.Salary_slip_timesheet)) { }
        public ERPSalary_slip_timesheet(ERPObject obj) : base(obj) { }

        public static ERPSalary_slip_timesheet Create(string timesheet, double workinghours)

        {
            ERPSalary_slip_timesheet obj = new ERPSalary_slip_timesheet();
            obj.time_sheet = timesheet;
            obj.working_hours = workinghours;
            return obj;
        }

        public string time_sheet
        {
            get { return data.time_sheet; }
            set
            {
                data.time_sheet = value;
                data.name = value;
            }

        }

        private double _working_hours = 0.0;
        public double working_hours
        {
            get { return data._working_hours; }
            set { data._working_hours = value; }
        }


    }

    //Enums go here

}