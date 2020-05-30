using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_amenity
{
    public class ERPHotel_room_amenity : ERPNextObjectBase
    {
        public ERPHotel_room_amenity() : this(new ERPObject(DocType.Hotel_room_amenity)) { }
        public ERPHotel_room_amenity(ERPObject obj) : base(obj) { }

        public static ERPHotel_room_amenity Create(string item, int billable)

        {
            ERPHotel_room_amenity obj = new ERPHotel_room_amenity();
            obj.item = item;
            obj.billable = billable;
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

        private int _billable = 0;
        public int billable
        {
            get { return data._billable; }
            set { data._billable = value; }
        }


    }

    //Enums go here

}