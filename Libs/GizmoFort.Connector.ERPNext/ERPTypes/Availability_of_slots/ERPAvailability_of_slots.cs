using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Availability_of_slots
{
    public class ERPAvailability_of_slots : ERPNextObjectBase
    {
        public ERPAvailability_of_slots() : this(new ERPObject(DocType.Availability_of_slots)) { }
        public ERPAvailability_of_slots(ERPObject obj) : base(obj) { }

        public static ERPAvailability_of_slots Create(Dayofweek dayofweek, string fromtime, string totime)

        {
            ERPAvailability_of_slots obj = new ERPAvailability_of_slots();
            obj.day_of_week = dayofweek;
            obj.from_time = fromtime;
            obj.to_time = totime;
            return obj;
        }

        public Dayofweek day_of_week
        {
            get { return parseEnum<Dayofweek>(data.day_of_week); }
            set { data.day_of_week = value.ToString(); }
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
    public enum Dayofweek
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