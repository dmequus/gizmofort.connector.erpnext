using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_trip
{
    public class ERPDelivery_trip : ERPNextObjectBase
    {
        public ERPDelivery_trip() : this(new ERPObject(DocType.Delivery_trip)) { }
        public ERPDelivery_trip(ERPObject obj) : base(obj) { }

        public static ERPDelivery_trip Create(string drivername, string company, string driver, string vehicle, string departuretime, string deliverystops)

        {
            ERPDelivery_trip obj = new ERPDelivery_trip();
            obj.driver_name = drivername;
            obj.company = company;
            obj.driver = driver;
            obj.vehicle = vehicle;
            obj.departure_time = departuretime;
            obj.delivery_stops = deliverystops;
            return obj;
        }

        public string driver_name
        {
            get { return data.driver_name; }
            set
            {
                data.driver_name = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string driver
        {
            get { return data.driver; }
            set { data.driver = value; }
        }

        public string vehicle
        {
            get { return data.vehicle; }
            set { data.vehicle = value; }
        }

        public string departure_time
        {
            get { return data.departure_time; }
            set { data.departure_time = value; }
        }

        public string delivery_stops
        {
            get { return data.delivery_stops; }
            set { data.delivery_stops = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        private int _email_notification_sent = 0;
        public int email_notification_sent
        {
            get { return data._email_notification_sent; }
            set { data._email_notification_sent = value; }
        }

        private double _total_distance = 0.0;
        public double total_distance
        {
            get { return data._total_distance; }
            set { data._total_distance = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string driver_address
        {
            get { return data.driver_address; }
            set { data.driver_address = value; }
        }

        public string driver_email
        {
            get { return data.driver_email; }
            set { data.driver_email = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Scheduled")]
        Scheduled,
        [Description("In Transit")]
        InTransit,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }


}