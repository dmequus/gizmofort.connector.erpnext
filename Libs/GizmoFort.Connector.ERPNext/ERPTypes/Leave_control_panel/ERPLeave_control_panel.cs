using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_control_panel
{
    public class ERPLeave_control_panel : ERPNextObjectBase
    {
        public ERPLeave_control_panel() : this(new ERPObject(DocType.Leave_control_panel)) { }
        public ERPLeave_control_panel(ERPObject obj) : base(obj) { }

        public static ERPLeave_control_panel Create(string fromdate, string todate, double noofdays)

        {
            ERPLeave_control_panel obj = new ERPLeave_control_panel();
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.no_of_days = noofdays;
            return obj;
        }

        public string from_date
        {
            get { return data.from_date; }
            set
            {
                data.from_date = value;
                data.name = value;
            }

        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public double no_of_days
        {
            get { return data.no_of_days; }
            set { data.no_of_days = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string employment_type
        {
            get { return data.employment_type; }
            set { data.employment_type = value; }
        }

        public string branch
        {
            get { return data.branch; }
            set { data.branch = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public string employee_grade
        {
            get { return data.employee_grade; }
            set { data.employee_grade = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string leave_policy
        {
            get { return data.leave_policy; }
            set { data.leave_policy = value; }
        }

        public string leave_type
        {
            get { return data.leave_type; }
            set { data.leave_type = value; }
        }

        public long carry_forward
        {
            get { return data.carry_forward; }
            set { data.carry_forward = value; }
        }


    }

    //Enums go here

}