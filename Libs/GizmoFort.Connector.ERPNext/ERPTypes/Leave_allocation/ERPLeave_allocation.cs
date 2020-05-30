using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_allocation
{
    public class ERPLeave_allocation : ERPNextObjectBase
    {
        public ERPLeave_allocation() : this(new ERPObject(DocType.Leave_allocation)) { }
        public ERPLeave_allocation(ERPObject obj) : base(obj) { }

        public static ERPLeave_allocation Create(string namingseries, string employee, string leavetype, string fromdate, string todate, double totalleavesallocated)

        {
            ERPLeave_allocation obj = new ERPLeave_allocation();
            obj.naming_series = namingseries;
            obj.employee = employee;
            obj.leave_type = leavetype;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.total_leaves_allocated = totalleavesallocated;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string leave_type
        {
            get { return data.leave_type; }
            set { data.leave_type = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public double total_leaves_allocated
        {
            get { return data.total_leaves_allocated; }
            set { data.total_leaves_allocated = value; }
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public double new_leaves_allocated
        {
            get { return data.new_leaves_allocated; }
            set { data.new_leaves_allocated = value; }
        }

        public long carry_forward
        {
            get { return data.carry_forward; }
            set { data.carry_forward = value; }
        }

        public double unused_leaves
        {
            get { return data.unused_leaves; }
            set { data.unused_leaves = value; }
        }

        public double total_leaves_encashed
        {
            get { return data.total_leaves_encashed; }
            set { data.total_leaves_encashed = value; }
        }

        public string compensatory_request
        {
            get { return data.compensatory_request; }
            set { data.compensatory_request = value; }
        }

        public string leave_period
        {
            get { return data.leave_period; }
            set { data.leave_period = value; }
        }

        public string leave_policy
        {
            get { return data.leave_policy; }
            set { data.leave_policy = value; }
        }

        public long expired
        {
            get { return data.expired; }
            set { data.expired = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public double carry_forwarded_leaves_count
        {
            get { return data.carry_forwarded_leaves_count; }
            set { data.carry_forwarded_leaves_count = value; }
        }


    }

    //Enums go here

}