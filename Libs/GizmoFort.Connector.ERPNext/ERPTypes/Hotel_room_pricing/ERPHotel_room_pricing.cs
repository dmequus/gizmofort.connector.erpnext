using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_pricing
{
    public class ERPHotel_room_pricing : ERPNextObjectBase
    {
        public ERPHotel_room_pricing() : this(new ERPObject(DocType.Hotel_room_pricing)) { }
        public ERPHotel_room_pricing(ERPObject obj) : base(obj) { }

        public static ERPHotel_room_pricing Create(int enabled, string currency, string fromdate, string todate, string items)

        {
            ERPHotel_room_pricing obj = new ERPHotel_room_pricing();
            obj.enabled = enabled;
            obj.currency = currency;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.items = items;
            return obj;
        }

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
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

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }


    }

    //Enums go here

}