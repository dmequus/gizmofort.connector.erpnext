using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Travel_itinerary
{
    public class ERPTravel_itinerary : ERPNextObjectBase
    {
        public ERPTravel_itinerary() : this(new ERPObject(DocType.Travel_itinerary)) { }
        public ERPTravel_itinerary(ERPObject obj) : base(obj) { }

        public static ERPTravel_itinerary Create(string travelfrom, string travelto, Modeoftravel modeoftravel, Mealpreference mealpreference, long traveladvancerequired, string advanceamount, string departuredate, string arrivaldate, long lodgingrequired, string preferredareaforlodging, string checkindate, string checkoutdate, string otherdetails)

        {
            ERPTravel_itinerary obj = new ERPTravel_itinerary();
            obj.travel_from = travelfrom;
            obj.travel_to = travelto;
            obj.mode_of_travel = modeoftravel;
            obj.meal_preference = mealpreference;
            obj.travel_advance_required = traveladvancerequired;
            obj.advance_amount = advanceamount;
            obj.departure_date = departuredate;
            obj.arrival_date = arrivaldate;
            obj.lodging_required = lodgingrequired;
            obj.preferred_area_for_lodging = preferredareaforlodging;
            obj.check_in_date = checkindate;
            obj.check_out_date = checkoutdate;
            obj.other_details = otherdetails;
            return obj;
        }

        public string travel_from
        {
            get { return data.travel_from; }
            set
            {
                data.travel_from = value;
                data.name = value;
            }

        }

        public string travel_to
        {
            get { return data.travel_to; }
            set { data.travel_to = value; }
        }

        public Modeoftravel mode_of_travel
        {
            get { return parseEnum<Modeoftravel>(data.mode_of_travel); }
            set { data.mode_of_travel = value.ToString(); }
        }

        public Mealpreference meal_preference
        {
            get { return parseEnum<Mealpreference>(data.meal_preference); }
            set { data.meal_preference = value.ToString(); }
        }

        public long travel_advance_required
        {
            get { return data.travel_advance_required; }
            set { data.travel_advance_required = value; }
        }

        public string advance_amount
        {
            get { return data.advance_amount; }
            set { data.advance_amount = value; }
        }

        public string departure_date
        {
            get { return data.departure_date; }
            set { data.departure_date = value; }
        }

        public string arrival_date
        {
            get { return data.arrival_date; }
            set { data.arrival_date = value; }
        }

        public long lodging_required
        {
            get { return data.lodging_required; }
            set { data.lodging_required = value; }
        }

        public string preferred_area_for_lodging
        {
            get { return data.preferred_area_for_lodging; }
            set { data.preferred_area_for_lodging = value; }
        }

        public string check_in_date
        {
            get { return data.check_in_date; }
            set { data.check_in_date = value; }
        }

        public string check_out_date
        {
            get { return data.check_out_date; }
            set { data.check_out_date = value; }
        }

        public string other_details
        {
            get { return data.other_details; }
            set { data.other_details = value; }
        }


    }

    //Enums go here
    public enum Modeoftravel
    {
        [Description("Flight")]
        Flight,
        [Description("Train")]
        Train,
        [Description("Taxi")]
        Taxi,
        [Description("Rented Car")]
        RentedCar,
    }

    public enum Mealpreference
    {
        [Description("Vegetarian")]
        Vegetarian,
        [Description("Non-Vegetarian")]
        NonVegetarian,
        [Description("Gluten Free")]
        GlutenFree,
        [Description("Non Diary")]
        NonDiary,
    }


}