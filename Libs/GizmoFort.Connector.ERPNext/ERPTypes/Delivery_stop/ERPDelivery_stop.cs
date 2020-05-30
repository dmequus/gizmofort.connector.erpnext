using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_stop
{
    public class ERPDelivery_stop : ERPNextObjectBase
    {
        public ERPDelivery_stop() : this(new ERPObject(DocType.Delivery_stop)) { }
        public ERPDelivery_stop(ERPObject obj) : base(obj) { }

        public static ERPDelivery_stop Create(string customer, string address, int keyDELlock, string customeraddress, int visited, string deliverynote, double grandtotal, string contact, string emailsentto, string customercontact, double distance, string estimatedarrival, double lat, string uom, double lng, string details)

        {
            ERPDelivery_stop obj = new ERPDelivery_stop();
            obj.customer = customer;
            obj.address = address;
            obj.keyDELlock = keyDELlock;
            obj.customer_address = customeraddress;
            obj.visited = visited;
            obj.delivery_note = deliverynote;
            obj.grand_total = grandtotal;
            obj.contact = contact;
            obj.email_sent_to = emailsentto;
            obj.customer_contact = customercontact;
            obj.distance = distance;
            obj.estimated_arrival = estimatedarrival;
            obj.lat = lat;
            obj.uom = uom;
            obj.lng = lng;
            obj.details = details;
            return obj;
        }

        public string customer
        {
            get { return data.customer; }
            set
            {
                data.customer = value;
                data.name = value;
            }

        }

        public string address
        {
            get { return data.address; }
            set { data.address = value; }
        }

        private int _keyDELlock = 0;
        public int keyDELlock
        {
            get { return data._keyDELlock; }
            set { data._keyDELlock = value; }
        }

        public string customer_address
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        private int _visited = 0;
        public int visited
        {
            get { return data._visited; }
            set { data._visited = value; }
        }

        public string delivery_note
        {
            get { return data.delivery_note; }
            set { data.delivery_note = value; }
        }

        private double _grand_total = 0.0;
        public double grand_total
        {
            get { return data._grand_total; }
            set { data._grand_total = value; }
        }

        public string contact
        {
            get { return data.contact; }
            set { data.contact = value; }
        }

        public string email_sent_to
        {
            get { return data.email_sent_to; }
            set { data.email_sent_to = value; }
        }

        public string customer_contact
        {
            get { return data.customer_contact; }
            set { data.customer_contact = value; }
        }

        private double _distance = 0.0;
        public double distance
        {
            get { return data._distance; }
            set { data._distance = value; }
        }

        public string estimated_arrival
        {
            get { return data.estimated_arrival; }
            set { data.estimated_arrival = value; }
        }

        private double _lat = 0.0;
        public double lat
        {
            get { return data._lat; }
            set { data._lat = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        private double _lng = 0.0;
        public double lng
        {
            get { return data._lng; }
            set { data._lng = value; }
        }

        public string details
        {
            get { return data.details; }
            set { data.details = value; }
        }


    }

    //Enums go here

}