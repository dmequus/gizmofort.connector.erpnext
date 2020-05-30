using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Travel_request
{
    public class ERPTravel_request : ERPNextObjectBase
    {
        public ERPTravel_request() : this(new ERPObject(DocType.Travel_request)) { }
        public ERPTravel_request(ERPObject obj) : base(obj) { }

        public static ERPTravel_request Create(Traveltype traveltype, string purposeoftravel, string employee)

        {
            ERPTravel_request obj = new ERPTravel_request();
            obj.travel_type = traveltype;
            obj.purpose_of_travel = purposeoftravel;
            obj.employee = employee;
            return obj;
        }

        public Traveltype travel_type
        {
            get { return parseEnum<Traveltype>(data.travel_type); }
            set { data.travel_type = value.ToString(); }
        }

        public string purpose_of_travel
        {
            get { return data.purpose_of_travel; }
            set { data.purpose_of_travel = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public Travelfunding travel_funding
        {
            get { return parseEnum<Travelfunding>(data.travel_funding); }
            set { data.travel_funding = value.ToString(); }
        }

        public string travel_proof
        {
            get { return data.travel_proof; }
            set { data.travel_proof = value; }
        }

        public string details_of_sponsor
        {
            get { return data.details_of_sponsor; }
            set { data.details_of_sponsor = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        public string cell_number
        {
            get { return data.cell_number; }
            set { data.cell_number = value; }
        }

        public string prefered_email
        {
            get { return data.prefered_email; }
            set { data.prefered_email = value; }
        }

        public string date_of_birth
        {
            get { return data.date_of_birth; }
            set { data.date_of_birth = value; }
        }

        public string personal_id_type
        {
            get { return data.personal_id_type; }
            set { data.personal_id_type = value; }
        }

        public string personal_id_number
        {
            get { return data.personal_id_number; }
            set { data.personal_id_number = value; }
        }

        public string passport_number
        {
            get { return data.passport_number; }
            set { data.passport_number = value; }
        }

        public string itinerary
        {
            get { return data.itinerary; }
            set { data.itinerary = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string costings
        {
            get { return data.costings; }
            set { data.costings = value; }
        }

        public string name_of_organizer
        {
            get { return data.name_of_organizer; }
            set { data.name_of_organizer = value; }
        }

        public string address_of_organizer
        {
            get { return data.address_of_organizer; }
            set { data.address_of_organizer = value; }
        }

        public string other_details
        {
            get { return data.other_details; }
            set { data.other_details = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Traveltype
    {
        [Description("Domestic")]
        Domestic,
        [Description("International")]
        International,
    }

    public enum Travelfunding
    {
        [Description("Require Full Funding")]
        RequireFullFunding,
        [Description("Fully Sponsored")]
        FullySponsored,
        [Description("Partially Sponsored, Require Partial Funding")]
        PartiallySponsoredRequirePartialFunding,
    }


}