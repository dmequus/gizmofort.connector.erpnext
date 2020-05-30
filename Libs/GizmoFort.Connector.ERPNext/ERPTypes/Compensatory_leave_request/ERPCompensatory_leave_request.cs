using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Compensatory_leave_request
{
    public class ERPCompensatory_leave_request : ERPNextObjectBase
    {
        public ERPCompensatory_leave_request() : this(new ERPObject(DocType.Compensatory_leave_request)) { }
        public ERPCompensatory_leave_request(ERPObject obj) : base(obj) { }

        public static ERPCompensatory_leave_request Create(string employeename, string employee, string department, string leavetype, string leaveallocation, string workfromdate, string workenddate, int halfday, string halfdaydate, string reason, string amendedfrom)

        {
            ERPCompensatory_leave_request obj = new ERPCompensatory_leave_request();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.department = department;
            obj.leave_type = leavetype;
            obj.leave_allocation = leaveallocation;
            obj.work_from_date = workfromdate;
            obj.work_end_date = workenddate;
            obj.half_day = halfday;
            obj.half_day_date = halfdaydate;
            obj.reason = reason;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set
            {
                data.employee_name = value;
                data.name = value;
            }

        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string leave_type
        {
            get { return data.leave_type; }
            set { data.leave_type = value; }
        }

        public string leave_allocation
        {
            get { return data.leave_allocation; }
            set { data.leave_allocation = value; }
        }

        public string work_from_date
        {
            get { return data.work_from_date; }
            set { data.work_from_date = value; }
        }

        public string work_end_date
        {
            get { return data.work_end_date; }
            set { data.work_end_date = value; }
        }

        private int _half_day = 0;
        public int half_day
        {
            get { return data._half_day; }
            set { data._half_day = value; }
        }

        public string half_day_date
        {
            get { return data.half_day_date; }
            set { data.half_day_date = value; }
        }

        public string reason
        {
            get { return data.reason; }
            set { data.reason = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}