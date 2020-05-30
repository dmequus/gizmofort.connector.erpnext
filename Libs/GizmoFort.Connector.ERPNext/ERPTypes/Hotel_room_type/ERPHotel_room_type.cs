using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_type
{
    public class ERPHotel_room_type : ERPNextObjectBase
    {
        public ERPHotel_room_type() : this(new ERPObject(DocType.Hotel_room_type)) { }
        public ERPHotel_room_type(ERPObject obj) : base(obj) { }

        public static ERPHotel_room_type Create(int capacity, int extrabedcapacity, string amenities)

        {
            ERPHotel_room_type obj = new ERPHotel_room_type();
            obj.capacity = capacity;
            obj.extra_bed_capacity = extrabedcapacity;
            obj.amenities = amenities;
            return obj;
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

        public string amenities
        {
            get { return data.amenities; }
            set { data.amenities = value; }
        }


    }

    //Enums go here

}