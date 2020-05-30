using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Communication_medium_timeslot
{
    public class ERPCommunication_medium_timeslot : ERPNextObjectBase
    {
        public ERPCommunication_medium_timeslot() : this(new ERPObject(DocType.Communication_medium_timeslot)) { }
        public ERPCommunication_medium_timeslot(ERPObject obj) : base(obj) { }

        public static ERPCommunication_medium_timeslot Create(Dayofweek dayofweek, string fromtime, string totime, string employeegroup)

        {
            ERPCommunication_medium_timeslot obj = new ERPCommunication_medium_timeslot();
            obj.day_of_week = dayofweek;
            obj.from_time = fromtime;
            obj.to_time = totime;
            obj.employee_group = employeegroup;
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

        public string employee_group
        {
            get { return data.employee_group; }
            set { data.employee_group = value; }
        }


    }

    //Enums go here
    public enum Dayofweek
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