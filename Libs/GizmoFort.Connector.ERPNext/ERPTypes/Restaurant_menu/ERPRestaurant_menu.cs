using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_menu
{
    public class ERPRestaurant_menu : ERPNextObjectBase
    {
        public ERPRestaurant_menu() : this(new ERPObject(DocType.Restaurant_menu)) { }
        public ERPRestaurant_menu(ERPObject obj) : base(obj) { }

        public static ERPRestaurant_menu Create(string restaurant, int enabled, string pricelist, string items)

        {
            ERPRestaurant_menu obj = new ERPRestaurant_menu();
            obj.restaurant = restaurant;
            obj.enabled = enabled;
            obj.price_list = pricelist;
            obj.items = items;
            return obj;
        }

        public string restaurant
        {
            get { return data.restaurant; }
            set
            {
                data.restaurant = value;
                data.name = value;
            }

        }

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
        }

        public string price_list
        {
            get { return data.price_list; }
            set { data.price_list = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }


    }

    //Enums go here

}