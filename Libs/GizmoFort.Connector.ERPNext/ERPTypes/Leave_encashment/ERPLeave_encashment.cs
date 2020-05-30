using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_encashment
{
    public class ERPLeave_encashment : ERPNextObjectBase
    {
        public ERPLeave_encashment() : this(new ERPObject(DocType.Leave_encashment)) { }
        public ERPLeave_encashment(ERPObject obj) : base(obj) { }

        public static ERPLeave_encashment Create(string leaveperiod, string employee, string leavetype)

        {
            ERPLeave_encashment obj = new ERPLeave_encashment();
            obj.leave_period = leaveperiod;
            obj.employee = employee;
            obj.leave_type = leavetype;
            return obj;
        }

        public string leave_period
        {
            get { return data.leave_period; }
            set
            {
                data.leave_period = value;
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

        public string leave_allocation
        {
            get { return data.leave_allocation; }
            set { data.leave_allocation = value; }
        }

        public double leave_balance
        {
            get { return data.leave_balance; }
            set { data.leave_balance = value; }
        }

        public double encashable_days
        {
            get { return data.encashable_days; }
            set { data.encashable_days = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public double encashment_amount
        {
            get { return data.encashment_amount; }
            set { data.encashment_amount = value; }
        }

        public string encashment_date
        {
            get { return data.encashment_date; }
            set { data.encashment_date = value; }
        }

        public string additional_salary
        {
            get { return data.additional_salary; }
            set { data.additional_salary = value; }
        }


    }

    //Enums go here

}