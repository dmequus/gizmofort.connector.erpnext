using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_meeting
{
    public class ERPQuality_meeting : ERPNextObjectBase
    {
        public ERPQuality_meeting() : this(new ERPObject(DocType.Quality_meeting)) { }
        public ERPQuality_meeting(ERPObject obj) : base(obj) { }

        public static ERPQuality_meeting Create()

        {
            ERPQuality_meeting obj = new ERPQuality_meeting();
            return obj;
        }

        public string date
        {
            get { return data.date; }
            set
            {
                data.date = value;
                data.name = value;
            }

        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string minutes
        {
            get { return data.minutes; }
            set { data.minutes = value; }
        }

        public string agenda
        {
            get { return data.agenda; }
            set { data.agenda = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Closed")]
        Closed,
    }


}