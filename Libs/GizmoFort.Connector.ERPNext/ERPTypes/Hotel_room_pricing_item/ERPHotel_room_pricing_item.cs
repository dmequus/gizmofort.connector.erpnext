using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_pricing_item
{
    public class ERPHotel_room_pricing_item : ERPNextObjectBase
    {
        public ERPHotel_room_pricing_item() : this(new ERPObject(DocType.Hotel_room_pricing_item)) { }
        public ERPHotel_room_pricing_item(ERPObject obj) : base(obj) { }

        public static ERPHotel_room_pricing_item Create(string item, double rate)

        {
            ERPHotel_room_pricing_item obj = new ERPHotel_room_pricing_item();
            obj.item = item;
            obj.rate = rate;
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

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }


    }

    //Enums go here

}