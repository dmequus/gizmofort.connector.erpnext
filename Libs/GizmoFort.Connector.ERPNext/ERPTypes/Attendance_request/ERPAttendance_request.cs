using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Attendance_request
{
    public class ERPAttendance_request : ERPNextObjectBase
    {
        public ERPAttendance_request() : this(new ERPObject(DocType.Attendance_request)) { }
        public ERPAttendance_request(ERPObject obj) : base(obj) { }

        public static ERPAttendance_request Create(string employeename, string employee, string company, string fromdate, string todate, Reason reason)

        {
            ERPAttendance_request obj = new ERPAttendance_request();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.company = company;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.reason = reason;
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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
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

        public Reason reason
        {
            get { return parseEnum<Reason>(data.reason); }
            set { data.reason = value.ToString(); }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public long half_day
        {
            get { return data.half_day; }
            set { data.half_day = value; }
        }

        public string half_day_date
        {
            get { return data.half_day_date; }
            set { data.half_day_date = value; }
        }

        public string explanation
        {
            get { return data.explanation; }
            set { data.explanation = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Reason
    {
        [Description("Work From Home")]
        WorkFromHome,
        [Description("On Duty")]
        OnDuty,
    }


}