using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_schedule_time_slot
{
    public class ERPHealthcare_schedule_time_slot : ERPNextObjectBase
    {
        public ERPHealthcare_schedule_time_slot() : this(new ERPObject(DocType.Healthcare_schedule_time_slot)) { }
        public ERPHealthcare_schedule_time_slot(ERPObject obj) : base(obj) { }

        public static ERPHealthcare_schedule_time_slot Create(Day day, string fromtime, string totime)

        {
            ERPHealthcare_schedule_time_slot obj = new ERPHealthcare_schedule_time_slot();
            obj.day = day;
            obj.from_time = fromtime;
            obj.to_time = totime;
            return obj;
        }

        public Day day
        {
            get { return parseEnum<Day>(data.day); }
            set { data.day = value.ToString(); }
        }

        public string from_time
        {
            get { return data.from_time; }
            set { data.from_time = value; }
        }

        public string to_time
        {
            get { return data.to_time; }
            set { data.to_time = value; }
        }


    }

    //Enums go here
    public enum Day
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