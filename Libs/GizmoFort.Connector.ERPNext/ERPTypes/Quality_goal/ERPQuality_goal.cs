using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_goal
{
    public class ERPQuality_goal : ERPNextObjectBase
    {
        public ERPQuality_goal() : this(new ERPObject(DocType.Quality_goal)) { }
        public ERPQuality_goal(ERPObject obj) : base(obj) { }

        public static ERPQuality_goal Create(string goal)

        {
            ERPQuality_goal obj = new ERPQuality_goal();
            obj.goal = goal;
            return obj;
        }

        public string goal
        {
            get { return data.goal; }
            set
            {
                data.goal = value;
                data.name = value;
            }

        }

        public string created_by
        {
            get { return data.created_by; }
            set { data.created_by = value; }
        }

        public Frequency frequency
        {
            get { return parseEnum<Frequency>(data.frequency); }
            set { data.frequency = value.ToString(); }
        }

        public string procedure
        {
            get { return data.procedure; }
            set { data.procedure = value; }
        }

        public Date date
        {
            get { return parseEnum<Date>(data.date); }
            set { data.date = value.ToString(); }
        }

        public int revision
        {
            get { return data.revision; }
            set { data.revision = value; }
        }

        public string revised_on
        {
            get { return data.revised_on; }
            set { data.revised_on = value; }
        }

        public Weekday weekday
        {
            get { return parseEnum<Weekday>(data.weekday); }
            set { data.weekday = value.ToString(); }
        }

        public string objectives
        {
            get { return data.objectives; }
            set { data.objectives = value; }
        }

        public string quarter
        {
            get { return data.quarter; }
            set { data.quarter = value; }
        }


    }

    //Enums go here
    public enum Frequency
    {
        [Description("None")]
        None,
        [Description("Daily")]
        Daily,
        [Description("Weekly")]
        Weekly,
        [Description("Monthly")]
        Monthly,
        [Description("Quarterly")]
        Quarterly,
    }

    public enum Date
    {
        [Description("1")]
        num1,
        [Description("2")]
        num2,
        [Description("3")]
        num3,
        [Description("4")]
        num4,
        [Description("5")]
        num5,
        [Description("6")]
        num6,
        [Description("7")]
        num7,
        [Description("8")]
        num8,
        [Description("9")]
        num9,
        [Description("10")]
        num10,
        [Description("11")]
        num11,
        [Description("12")]
        num12,
        [Description("13")]
        num13,
        [Description("14")]
        num14,
        [Description("15")]
        num15,
        [Description("16")]
        num16,
        [Description("17")]
        num17,
        [Description("18")]
        num18,
        [Description("19")]
        num19,
        [Description("20")]
        num20,
        [Description("21")]
        num21,
        [Description("22")]
        num22,
        [Description("23")]
        num23,
        [Description("24")]
        num24,
        [Description("25")]
        num25,
        [Description("26")]
        num26,
        [Description("27")]
        num27,
        [Description("28")]
        num28,
        [Description("29")]
        num29,
        [Description("30")]
        num30,
    }

    public enum Weekday
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
    }


}