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

        public int response_time
        {
            get { return data.response_time; }
            set { data.response_time = value; }
        }

        public int resolution_time
        {
            get { return data.resolution_time; }
            set { data.resolution_time = value; }
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

        public long default_priority
        {
            get { return data.default_priority; }
            set { data.default_priority = value; }
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