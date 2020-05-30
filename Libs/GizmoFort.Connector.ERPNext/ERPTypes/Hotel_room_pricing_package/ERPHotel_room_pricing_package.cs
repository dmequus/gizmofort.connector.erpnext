using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_pricing_package
{
    public class ERPHotel_room_pricing_package : ERPNextObjectBase
    {
        public ERPHotel_room_pricing_package() : this(new ERPObject(DocType.Hotel_room_pricing_package)) { }
        public ERPHotel_room_pricing_package(ERPObject obj) : base(obj) { }

        public static ERPHotel_room_pricing_package Create(string fromdate, string todate, string hotelroompackage, double rate)

        {
            ERPHotel_room_pricing_package obj = new ERPHotel_room_pricing_package();
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.hotel_room_package = hotelroompackage;
            obj.rate = rate;
            return obj;
        }

        public string from_date
        {
            get { return data.from_date; }
            set
            {
                data.from_date = value;
                data.name = value;
            }

        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public string hotel_room_package
        {
            get { return data.hotel_room_package; }
            set { data.hotel_room_package = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }


    }

    //Enums go here

}