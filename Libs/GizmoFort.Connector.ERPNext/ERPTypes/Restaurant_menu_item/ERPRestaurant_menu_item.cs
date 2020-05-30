using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_menu_item
{
    public class ERPRestaurant_menu_item : ERPNextObjectBase
    {
        public ERPRestaurant_menu_item() : this(new ERPObject(DocType.Restaurant_menu_item)) { }
        public ERPRestaurant_menu_item(ERPObject obj) : base(obj) { }

        public static ERPRestaurant_menu_item Create(string item, double rate)

        {
            ERPRestaurant_menu_item obj = new ERPRestaurant_menu_item();
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