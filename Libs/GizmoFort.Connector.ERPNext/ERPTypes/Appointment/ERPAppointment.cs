using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment
{
    public class ERPAppointment : ERPNextObjectBase
    {
        public ERPAppointment() : this(new ERPObject(DocType.Appointment)) { }
        public ERPAppointment(ERPObject obj) : base(obj) { }

        public static ERPAppointment Create(string customername, string scheduledtime, Status status, string customeremail)

        {
            ERPAppointment obj = new ERPAppointment();
            obj.customer_name = customername;
            obj.scheduled_time = scheduledtime;
            obj.status = status;
            obj.customer_email = customeremail;
            return obj;
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set
            {
                data.customer_name = value;
                data.name = value;
            }

        }

        public string scheduled_time
        {
            get { return data.scheduled_time; }
            set { data.scheduled_time = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string customer_email
        {
            get { return data.customer_email; }
            set { data.customer_email = value; }
        }

        public string customer_phone_number
        {
            get { return data.customer_phone_number; }
            set { data.customer_phone_number = value; }
        }

        public string customer_skype
        {
            get { return data.customer_skype; }
            set { data.customer_skype = value; }
        }

        public string customer_details
        {
            get { return data.customer_details; }
            set { data.customer_details = value; }
        }

        public string calendar_event
        {
            get { return data.calendar_event; }
            set { data.calendar_event = value; }
        }

        public string appointment_with
        {
            get { return data.appointment_with; }
            set { data.appointment_with = value; }
        }

        public string party
        {
            get { return data.party; }
            set { data.party = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Unverified")]
        Unverified,
        [Description("Closed")]
        Closed,
    }


}