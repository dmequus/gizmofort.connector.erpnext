using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Call_log
{
    public class ERPCall_log : ERPNextObjectBase
    {
        public ERPCall_log() : this(new ERPObject(DocType.Call_log)) { }
        public ERPCall_log(ERPObject obj) : base(obj) { }

        public static ERPCall_log Create(string from)

        {
            ERPCall_log obj = new ERPCall_log();
            obj.from = from;
            return obj;
        }

        public string from
        {
            get { return data.from; }
            set
            {
                data.from = value;
                data.name = value;
            }

        }

        public string id
        {
            get { return data.id; }
            set { data.id = value; }
        }

        public string to
        {
            get { return data.to; }
            set { data.to = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public int duration
        {
            get { return data.duration; }
            set { data.duration = value; }
        }

        public string recording_url
        {
            get { return data.recording_url; }
            set { data.recording_url = value; }
        }

        public string medium
        {
            get { return data.medium; }
            set { data.medium = value; }
        }

        public string received_by
        {
            get { return data.received_by; }
            set { data.received_by = value; }
        }

        public string contact
        {
            get { return data.contact; }
            set { data.contact = value; }
        }

        public string lead
        {
            get { return data.lead; }
            set { data.lead = value; }
        }

        public string contact_name
        {
            get { return data.contact_name; }
            set { data.contact_name = value; }
        }

        public string lead_name
        {
            get { return data.lead_name; }
            set { data.lead_name = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Ringing")]
        Ringing,
        [Description("In Progress")]
        InProgress,
        [Description("Completed")]
        Completed,
        [Description("Missed")]
        Missed,
    }


}