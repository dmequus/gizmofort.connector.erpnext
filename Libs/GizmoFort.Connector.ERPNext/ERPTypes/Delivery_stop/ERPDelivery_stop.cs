using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_stop
{
    public class ERPDelivery_stop : ERPNextObjectBase
    {
        public ERPDelivery_stop() : this(new ERPObject(DocType.Delivery_stop)) { }
        public ERPDelivery_stop(ERPObject obj) : base(obj) { }

        public static ERPDelivery_stop Create(string customer, string address, long keyDELlock, string customeraddress, long visited, string deliverynote, double grandtotal, string contact, string emailsentto, string customercontact, double distance, string estimatedarrival, double lat, string uom, double lng, string details)

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

        public long keyDELlock
        {
            get { return data.keyDELlock; }
            set { data.keyDELlock = value; }
        }

        public string customer_address
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        public long visited
        {
            get { return data.visited; }
            set { data.visited = value; }
        }

        public string delivery_note
        {
            get { return data.delivery_note; }
            set { data.delivery_note = value; }
        }

        public double grand_total
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
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

        public double distance
        {
            get { return data.distance; }
            set { data.distance = value; }
        }

        public string estimated_arrival
        {
            get { return data.estimated_arrival; }
            set { data.estimated_arrival = value; }
        }

        public double lat
        {
            get { return data.lat; }
            set { data.lat = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public double lng
        {
            get { return data.lng; }
            set { data.lng = value; }
        }

        public string details
        {
            get { return data.details; }
            set { data.details = value; }
        }


    }

    //Enums go here

}