using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_reservation
{
    public class ERPHotel_room_reservation : ERPNextObjectBase
    {
        public ERPHotel_room_reservation() : this(new ERPObject(DocType.Hotel_room_reservation)) { }
        public ERPHotel_room_reservation(ERPObject obj) : base(obj) { }

        public static ERPHotel_room_reservation Create(string guestname, string customer, string fromdate, string todate, int latecheckin, Status status, string items, double nettotal, string amendedfrom)

        {
            ERPHotel_room_reservation obj = new ERPHotel_room_reservation();
            obj.guest_name = guestname;
            obj.customer = customer;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.late_checkin = latecheckin;
            obj.status = status;
            obj.items = items;
            obj.net_total = nettotal;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string guest_name
        {
            get { return data.guest_name; }
            set
            {
                data.guest_name = value;
                data.name = value;
            }

        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        private int _late_checkin = 0;
        public int late_checkin
        {
            get { return data._late_checkin; }
            set { data._late_checkin = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        private double _net_total = 0.0;
        public double net_total
        {
            get { return data._net_total; }
            set { data._net_total = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Booked")]
        Booked,
        [Description("Advance Paid")]
        AdvancePaid,
        [Description("Invoiced")]
        Invoiced,
        [Description("Paid")]
        Paid,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }


}