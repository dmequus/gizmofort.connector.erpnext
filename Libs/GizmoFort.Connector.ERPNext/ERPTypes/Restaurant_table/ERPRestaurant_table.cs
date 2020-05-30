using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_table
{
    public class ERPRestaurant_table : ERPNextObjectBase
    {
        public ERPRestaurant_table() : this(new ERPObject(DocType.Restaurant_table)) { }
        public ERPRestaurant_table(ERPObject obj) : base(obj) { }

        public static ERPRestaurant_table Create(string restaurant, int noofseats, int minimumseating)

        {
            ERPRestaurant_table obj = new ERPRestaurant_table();
            obj.restaurant = restaurant;
            obj.no_of_seats = noofseats;
            obj.minimum_seating = minimumseating;
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

        public int no_of_seats
        {
            get { return data.no_of_seats; }
            set { data.no_of_seats = value; }
        }

        public int minimum_seating
        {
            get { return data.minimum_seating; }
            set { data.minimum_seating = value; }
        }


    }

    //Enums go here

}