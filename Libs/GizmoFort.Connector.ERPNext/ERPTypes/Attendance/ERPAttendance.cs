using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Attendance
{
    public class ERPAttendance : ERPNextObjectBase
    {
        public ERPAttendance() : this(new ERPObject(DocType.Attendance)) { }
        public ERPAttendance(ERPObject obj) : base(obj) { }

        public static ERPAttendance Create(string employeename, string namingseries, string employee, Status status, string attendancedate, string company)

        {
            ERPAttendance obj = new ERPAttendance();
            obj.employee_name = employeename;
            obj.naming_series = namingseries;
            obj.employee = employee;
            obj.status = status;
            obj.attendance_date = attendancedate;
            obj.company = company;
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

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string attendance_date
        {
            get { return data.attendance_date; }
            set { data.attendance_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public double working_hours
        {
            get { return data.working_hours; }
            set { data.working_hours = value; }
        }

        public string leave_type
        {
            get { return data.leave_type; }
            set { data.leave_type = value; }
        }

        public string leave_application
        {
            get { return data.leave_application; }
            set { data.leave_application = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string shift
        {
            get { return data.shift; }
            set { data.shift = value; }
        }

        public string attendance_request
        {
            get { return data.attendance_request; }
            set { data.attendance_request = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public long late_entry
        {
            get { return data.late_entry; }
            set { data.late_entry = value; }
        }

        public long early_exit
        {
            get { return data.early_exit; }
            set { data.early_exit = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Present")]
        Present,
        [Description("Absent")]
        Absent,
        [Description("On Leave")]
        OnLeave,
        [Description("Half Day")]
        HalfDay,
        [Description("Work From Home")]
        WorkFromHome,
    }


}