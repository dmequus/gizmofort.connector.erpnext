using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Workstation_working_hour
{
    public class ERPWorkstation_working_hour : ERPNextObjectBase
    {
        public ERPWorkstation_working_hour() : this(new ERPObject(DocType.Workstation_working_hour)) { }
        public ERPWorkstation_working_hour(ERPObject obj) : base(obj) { }

        public static ERPWorkstation_working_hour Create(string starttime, string endtime, long enabled)

        {
            ERPWorkstation_working_hour obj = new ERPWorkstation_working_hour();
            obj.start_time = starttime;
            obj.end_time = endtime;
            obj.enabled = enabled;
            return obj;
        }

        public string start_time
        {
            get { return data.start_time; }
            set
            {
                data.start_time = value;
                data.name = value;
            }

        }

        public string end_time
        {
            get { return data.end_time; }
            set { data.end_time = value; }
        }

        public long enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
        }


    }

    //Enums go here

}