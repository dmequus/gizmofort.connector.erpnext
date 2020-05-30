using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Holiday_list
{
    public class ERPHoliday_list : ERPNextObjectBase
    {
        public ERPHoliday_list() : this(new ERPObject(DocType.Holiday_list)) { }
        public ERPHoliday_list(ERPObject obj) : base(obj) { }

        public static ERPHoliday_list Create(string holidaylistname, string fromdate, string todate, int totalholidays, Weeklyoff weeklyoff, string holidays, string color)

        {
            ERPHoliday_list obj = new ERPHoliday_list();
            obj.holiday_list_name = holidaylistname;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.total_holidays = totalholidays;
            obj.weekly_off = weeklyoff;
            obj.holidays = holidays;
            obj.color = color;
            return obj;
        }

        public string holiday_list_name
        {
            get { return data.holiday_list_name; }
            set
            {
                data.holiday_list_name = value;
                data.name = value;
            }

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

        public int total_holidays
        {
            get { return data.total_holidays; }
            set { data.total_holidays = value; }
        }

        public Weeklyoff weekly_off
        {
            get { return parseEnum<Weeklyoff>(data.weekly_off); }
            set { data.weekly_off = value.ToString(); }
        }

        public string holidays
        {
            get { return data.holidays; }
            set { data.holidays = value; }
        }

        public string color
        {
            get { return data.color; }
            set { data.color = value; }
        }


    }

    //Enums go here
    public enum Weeklyoff
    {
        [Description("Sunday")]
        Sunday,
        [Description("Monday")]
        Monday,
        [Description("Tuesday")]
        Tuesday,
        [Description("Wednesday")]
        Wednesday,
        [Description("Thursday")]
        Thursday,
        [Description("Friday")]
        Friday,
        [Description("Saturday")]
        Saturday,
    }


}