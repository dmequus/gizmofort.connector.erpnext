using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Agriculture_task
{
    public class ERPAgriculture_task : ERPNextObjectBase
    {
        public ERPAgriculture_task() : this(new ERPObject(DocType.Agriculture_task)) { }
        public ERPAgriculture_task(ERPObject obj) : base(obj) { }

        public static ERPAgriculture_task Create(string taskname, int startday, int endday, Holidaymanagement holidaymanagement, Priority priority)

        {
            ERPAgriculture_task obj = new ERPAgriculture_task();
            obj.task_name = taskname;
            obj.start_day = startday;
            obj.end_day = endday;
            obj.holiday_management = holidaymanagement;
            obj.priority = priority;
            return obj;
        }

        public string task_name
        {
            get { return data.task_name; }
            set
            {
                data.task_name = value;
                data.name = value;
            }

        }

        public int start_day
        {
            get { return data.start_day; }
            set { data.start_day = value; }
        }

        public int end_day
        {
            get { return data.end_day; }
            set { data.end_day = value; }
        }

        public Holidaymanagement holiday_management
        {
            get { return parseEnum<Holidaymanagement>(data.holiday_management); }
            set { data.holiday_management = value.ToString(); }
        }

        public Priority priority
        {
            get { return parseEnum<Priority>(data.priority); }
            set { data.priority = value.ToString(); }
        }


    }

    //Enums go here
    public enum Holidaymanagement
    {
        [Description("Ignore holidays")]
        Ignoreholidays,
        [Description("Previous Business Day")]
        PreviousBusinessDay,
        [Description("Next Business Day")]
        NextBusinessDay,
    }

    public enum Priority
    {
        [Description("Low")]
        Low,
        [Description("Medium")]
        Medium,
        [Description("High")]
        High,
        [Description("Urgent")]
        Urgent,
    }


}