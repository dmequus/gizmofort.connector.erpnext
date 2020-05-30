using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Service_level_priority
{
    public class ERPService_level_priority : ERPNextObjectBase
    {
        public ERPService_level_priority() : this(new ERPObject(DocType.Service_level_priority)) { }
        public ERPService_level_priority(ERPObject obj) : base(obj) { }

        public static ERPService_level_priority Create()

        {
            ERPService_level_priority obj = new ERPService_level_priority();
            return obj;
        }

        public string priority
        {
            get { return data.priority; }
            set
            {
                data.priority = value;
                data.name = value;
            }

        }

        private int _response_time = 0;
        public int response_time
        {
            get { return data._response_time; }
            set { data._response_time = value; }
        }

        private int _resolution_time = 0;
        public int resolution_time
        {
            get { return data._resolution_time; }
            set { data._resolution_time = value; }
        }

        public Responsetimeperiod response_time_period
        {
            get { return parseEnum<Responsetimeperiod>(data.response_time_period); }
            set { data.response_time_period = value.ToString(); }
        }

        public Resolutiontimeperiod resolution_time_period
        {
            get { return parseEnum<Resolutiontimeperiod>(data.resolution_time_period); }
            set { data.resolution_time_period = value.ToString(); }
        }

        private int _default_priority = 0;
        public int default_priority
        {
            get { return data._default_priority; }
            set { data._default_priority = value; }
        }


    }

    //Enums go here
    public enum Responsetimeperiod
    {
        [Description("Hour")]
        Hour,
        [Description("Day")]
        Day,
        [Description("Week")]
        Week,
    }

    public enum Resolutiontimeperiod
    {
        [Description("Hour")]
        Hour,
        [Description("Day")]
        Day,
        [Description("Week")]
        Week,
    }


}