using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_package
{
    public class ERPHotel_room_package : ERPNextObjectBase
    {
        public ERPHotel_room_package() : this(new ERPObject(DocType.Hotel_room_package)) { }
        public ERPHotel_room_package(ERPObject obj) : base(obj) { }

        public static ERPHotel_room_package Create(string hotelroomtype, string item, string amenities)

        {
            ERPHotel_room_package obj = new ERPHotel_room_package();
            obj.hotel_room_type = hotelroomtype;
            obj.item = item;
            obj.amenities = amenities;
            return obj;
        }

        public string hotel_room_type
        {
            get { return data.hotel_room_type; }
            set
            {
                data.hotel_room_type = value;
                data.name = value;
            }

        }

        public string item
        {
            get { return data.item; }
            set { data.item = value; }
        }

        public string amenities
        {
            get { return data.amenities; }
            set { data.amenities = value; }
        }


    }

    //Enums go here

}