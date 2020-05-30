using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_booking_settings
{
    public class ERPAppointment_booking_settings : ERPNextObjectBase
    {
        public ERPAppointment_booking_settings() : this(new ERPObject(DocType.Appointment_booking_settings)) { }
        public ERPAppointment_booking_settings(ERPObject obj) : base(obj) { }

        public static ERPAppointment_booking_settings Create(string availabilityofslots, int numberofagents, string holidaylist, int appointmentduration, int advancebookingdays, string agentlist, long enablescheduling)

        {
            ERPAppointment_booking_settings obj = new ERPAppointment_booking_settings();
            obj.availability_of_slots = availabilityofslots;
            obj.number_of_agents = numberofagents;
            obj.holiday_list = holidaylist;
            obj.appointment_duration = appointmentduration;
            obj.advance_booking_days = advancebookingdays;
            obj.agent_list = agentlist;
            obj.enable_scheduling = enablescheduling;
            return obj;
        }

        public string availability_of_slots
        {
            get { return data.availability_of_slots; }
            set
            {
                data.availability_of_slots = value;
                data.name = value;
            }

        }

        public int number_of_agents
        {
            get { return data.number_of_agents; }
            set { data.number_of_agents = value; }
        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        public int appointment_duration
        {
            get { return data.appointment_duration; }
            set { data.appointment_duration = value; }
        }

        public int advance_booking_days
        {
            get { return data.advance_booking_days; }
            set { data.advance_booking_days = value; }
        }

        public string agent_list
        {
            get { return data.agent_list; }
            set { data.agent_list = value; }
        }

        public long enable_scheduling
        {
            get { return data.enable_scheduling; }
            set { data.enable_scheduling = value; }
        }

        public long email_reminders
        {
            get { return data.email_reminders; }
            set { data.email_reminders = value; }
        }

        public string success_redirect_url
        {
            get { return data.success_redirect_url; }
            set { data.success_redirect_url = value; }
        }


    }

    //Enums go here

}