using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_checkin
{
    public class ERPEmployee_checkin : ERPNextObjectBase
    {
        public ERPEmployee_checkin() : this(new ERPObject(DocType.Employee_checkin)) { }
        public ERPEmployee_checkin(ERPObject obj) : base(obj) { }

        public static ERPEmployee_checkin Create(string employeename, string employee, Logtype logtype, string time)

        {
            ERPEmployee_checkin obj = new ERPEmployee_checkin();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.log_type = logtype;
            obj.time = time;
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

        public Logtype log_type
        {
            get { return parseEnum<Logtype>(data.log_type); }
            set { data.log_type = value.ToString(); }
        }

        public string time
        {
            get { return data.time; }
            set { data.time = value; }
        }

        public string shift
        {
            get { return data.shift; }
            set { data.shift = value; }
        }

        public string device_id
        {
            get { return data.device_id; }
            set { data.device_id = value; }
        }

        public long skip_auto_attendance
        {
            get { return data.skip_auto_attendance; }
            set { data.skip_auto_attendance = value; }
        }

        public string attendance
        {
            get { return data.attendance; }
            set { data.attendance = value; }
        }

        public string shift_start
        {
            get { return data.shift_start; }
            set { data.shift_start = value; }
        }

        public string shift_end
        {
            get { return data.shift_end; }
            set { data.shift_end = value; }
        }

        public string shift_actual_start
        {
            get { return data.shift_actual_start; }
            set { data.shift_actual_start = value; }
        }

        public string shift_actual_end
        {
            get { return data.shift_actual_end; }
            set { data.shift_actual_end = value; }
        }


    }

    //Enums go here
    public enum Logtype
    {
        [Description("IN")]
        IN,
        [Description("OUT")]
        OUT,
    }


}