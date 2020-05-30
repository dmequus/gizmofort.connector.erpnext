using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Volunteer
{
    public class ERPVolunteer : ERPNextObjectBase
    {
        public ERPVolunteer() : this(new ERPObject(DocType.Volunteer)) { }
        public ERPVolunteer(ERPObject obj) : base(obj) { }

        public static ERPVolunteer Create(string volunteername, string volunteertype, string email, string image, string addresshtml, string contacthtml, Availability availability, Availabilitytimeslot availabilitytimeslot, string volunteerskills, string note)

        {
            ERPVolunteer obj = new ERPVolunteer();
            obj.volunteer_name = volunteername;
            obj.volunteer_type = volunteertype;
            obj.email = email;
            obj.image = image;
            obj.address_html = addresshtml;
            obj.contact_html = contacthtml;
            obj.availability = availability;
            obj.availability_timeslot = availabilitytimeslot;
            obj.volunteer_skills = volunteerskills;
            obj.note = note;
            return obj;
        }

        public string volunteer_name
        {
            get { return data.volunteer_name; }
            set
            {
                data.volunteer_name = value;
                data.name = value;
            }

        }

        public string volunteer_type
        {
            get { return data.volunteer_type; }
            set { data.volunteer_type = value; }
        }

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }

        public Availability availability
        {
            get { return parseEnum<Availability>(data.availability); }
            set { data.availability = value.ToString(); }
        }

        public Availabilitytimeslot availability_timeslot
        {
            get { return parseEnum<Availabilitytimeslot>(data.availability_timeslot); }
            set { data.availability_timeslot = value.ToString(); }
        }

        public string volunteer_skills
        {
            get { return data.volunteer_skills; }
            set { data.volunteer_skills = value; }
        }

        public string note
        {
            get { return data.note; }
            set { data.note = value; }
        }


    }

    //Enums go here
    public enum Availability
    {
        [Description("Weekly")]
        Weekly,
        [Description("Weekdays")]
        Weekdays,
        [Description("Weekends")]
        Weekends,
    }

    public enum Availabilitytimeslot
    {
        [Description("Morning")]
        Morning,
        [Description("Afternoon")]
        Afternoon,
        [Description("Evening")]
        Evening,
        [Description("Anytime")]
        Anytime,
    }


}