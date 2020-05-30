using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Service_day
{
    public class ERPService_day : ERPNextObjectBase
    {
        public ERPService_day() : this(new ERPObject(DocType.Service_day)) { }
        public ERPService_day(ERPObject obj) : base(obj) { }

        public static ERPService_day Create()

        {
            ERPService_day obj = new ERPService_day();
            return obj;
        }

        public Workday workday
        {
            get { return parseEnum<Workday>(data.workday); }
            set { data.workday = value.ToString(); }
        }

        public string start_time
        {
            get { return data.start_time; }
            set { data.start_time = value; }
        }

        public string end_time
        {
            get { return data.end_time; }
            set { data.end_time = value; }
        }


    }

    //Enums go here
    public enum Workday
    {
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
        [Description("Sunday")]
        Sunday,
    }


}