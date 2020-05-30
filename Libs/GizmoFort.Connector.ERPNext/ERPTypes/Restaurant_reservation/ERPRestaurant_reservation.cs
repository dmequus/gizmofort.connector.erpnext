using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_reservation
{
    public class ERPRestaurant_reservation : ERPNextObjectBase
    {
        public ERPRestaurant_reservation() : this(new ERPObject(DocType.Restaurant_reservation)) { }
        public ERPRestaurant_reservation(ERPObject obj) : base(obj) { }

        public static ERPRestaurant_reservation Create(Status status, string restaurant, int noofpeople, string reservationtime, string reservationendtime, string customer, string customername, string contactnumber)

        {
            ERPRestaurant_reservation obj = new ERPRestaurant_reservation();
            obj.status = status;
            obj.restaurant = restaurant;
            obj.no_of_people = noofpeople;
            obj.reservation_time = reservationtime;
            obj.reservation_end_time = reservationendtime;
            obj.customer = customer;
            obj.customer_name = customername;
            obj.contact_number = contactnumber;
            return obj;
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string restaurant
        {
            get { return data.restaurant; }
            set { data.restaurant = value; }
        }

        private int _no_of_people = 0;
        public int no_of_people
        {
            get { return data._no_of_people; }
            set { data._no_of_people = value; }
        }

        public string reservation_time
        {
            get { return data.reservation_time; }
            set { data.reservation_time = value; }
        }

        public string reservation_end_time
        {
            get { return data.reservation_end_time; }
            set { data.reservation_end_time = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string contact_number
        {
            get { return data.contact_number; }
            set { data.contact_number = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Waitlisted")]
        Waitlisted,
        [Description("Cancelled")]
        Cancelled,
        [Description("No Show")]
        NoShow,
        [Description("Success")]
        Success,
    }


}