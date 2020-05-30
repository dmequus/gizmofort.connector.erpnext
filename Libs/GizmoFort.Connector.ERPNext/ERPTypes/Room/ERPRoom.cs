using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Room
{
    public class ERPRoom : ERPNextObjectBase
    {
        public ERPRoom() : this(new ERPObject(DocType.Room)) { }
        public ERPRoom(ERPObject obj) : base(obj) { }

        public static ERPRoom Create(string roomname, string roomnumber, string seatingcapacity)

        {
            ERPRoom obj = new ERPRoom();
            obj.room_name = roomname;
            obj.room_number = roomnumber;
            obj.seating_capacity = seatingcapacity;
            return obj;
        }

        public string room_name
        {
            get { return data.room_name; }
            set
            {
                data.room_name = value;
                data.name = value;
            }

        }

        public string room_number
        {
            get { return data.room_number; }
            set { data.room_number = value; }
        }

        public string seating_capacity
        {
            get { return data.seating_capacity; }
            set { data.seating_capacity = value; }
        }


    }

    //Enums go here

}