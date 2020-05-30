using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Daily_work_summary_group
{
    public class ERPDaily_work_summary_group : ERPNextObjectBase
    {
        public ERPDaily_work_summary_group() : this(new ERPObject(DocType.Daily_work_summary_group)) { }
        public ERPDaily_work_summary_group(ERPObject obj) : base(obj) { }

        public static ERPDaily_work_summary_group Create(int enabled, string users, Sendemailsat sendemailsat, string holidaylist, string subject, string message)

        {
            ERPDaily_work_summary_group obj = new ERPDaily_work_summary_group();
            obj.enabled = enabled;
            obj.users = users;
            obj.send_emails_at = sendemailsat;
            obj.holiday_list = holidaylist;
            obj.subject = subject;
            obj.message = message;
            return obj;
        }

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
        }

        public string users
        {
            get { return data.users; }
            set { data.users = value; }
        }

        public Sendemailsat send_emails_at
        {
            get { return parseEnum<Sendemailsat>(data.send_emails_at); }
            set { data.send_emails_at = value.ToString(); }
        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        public string subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        public string message
        {
            get { return data.message; }
            set { data.message = value; }
        }


    }

    //Enums go here
    public enum Sendemailsat
    {
        [Description("00:00")]
        num0000,
        [Description("01:00")]
        num0100,
        [Description("02:00")]
        num0200,
        [Description("03:00")]
        num0300,
        [Description("04:00")]
        num0400,
        [Description("05:00")]
        num0500,
        [Description("06:00")]
        num0600,
        [Description("07:00")]
        num0700,
        [Description("08:00")]
        num0800,
        [Description("09:00")]
        num0900,
        [Description("10:00")]
        num1000,
        [Description("11:00")]
        num1100,
        [Description("12:00")]
        num1200,
        [Description("13:00")]
        num1300,
        [Description("14:00")]
        num1400,
        [Description("15:00")]
        num1500,
        [Description("16:00")]
        num1600,
        [Description("17:00")]
        num1700,
        [Description("18:00")]
        num1800,
        [Description("19:00")]
        num1900,
        [Description("20:00")]
        num2000,
        [Description("21:00")]
        num2100,
        [Description("22:00")]
        num2200,
        [Description("23:00")]
        num2300,
    }


}