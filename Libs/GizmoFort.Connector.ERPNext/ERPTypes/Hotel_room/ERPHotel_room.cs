using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room
{
    public class ERPHotel_room : ERPNextObjectBase
    {
        public ERPHotel_room() : this(new ERPObject(DocType.Hotel_room)) { }
        public ERPHotel_room(ERPObject obj) : base(obj) { }

        public static ERPHotel_room Create(string hotelroomtype, int capacity, int extrabedcapacity)

        {
            ERPHotel_room obj = new ERPHotel_room();
            obj.hotel_room_type = hotelroomtype;
            obj.capacity = capacity;
            obj.extra_bed_capacity = extrabedcapacity;
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

        private int _capacity = 0;
        public int capacity
        {
            get { return data._capacity; }
            set { data._capacity = value; }
        }

        private int _extra_bed_capacity = 0;
        public int extra_bed_capacity
        {
            get { return data._extra_bed_capacity; }
            set { data._extra_bed_capacity = value; }
        }


    }

    //Enums go here

}