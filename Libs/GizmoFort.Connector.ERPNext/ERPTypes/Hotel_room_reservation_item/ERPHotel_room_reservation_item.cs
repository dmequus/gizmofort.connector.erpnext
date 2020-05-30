using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_reservation_item
{
    public class ERPHotel_room_reservation_item : ERPNextObjectBase
    {
        public ERPHotel_room_reservation_item() : this(new ERPObject(DocType.Hotel_room_reservation_item)) { }
        public ERPHotel_room_reservation_item(ERPObject obj) : base(obj) { }

        public static ERPHotel_room_reservation_item Create(string item, int qty, string currency, double rate, double amount)

        {
            ERPHotel_room_reservation_item obj = new ERPHotel_room_reservation_item();
            obj.item = item;
            obj.qty = qty;
            obj.currency = currency;
            obj.rate = rate;
            obj.amount = amount;
            return obj;
        }

        public string item
        {
            get { return data.item; }
            set
            {
                data.item = value;
                data.name = value;
            }

        }

        private int _qty = 0;
        public int qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }


    }

    //Enums go here

}