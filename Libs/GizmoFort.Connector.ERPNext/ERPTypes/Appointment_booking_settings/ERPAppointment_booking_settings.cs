using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_booking_settings
{
    public class ERPAppointment_booking_settings : ERPNextObjectBase
    {
        public ERPAppointment_booking_settings() : this(new ERPObject(DocType.Appointment_booking_settings)) { }
        public ERPAppointment_booking_settings(ERPObject obj) : base(obj) { }

        public static ERPAppointment_booking_settings Create(string availabilityofslots, int numberofagents, string holidaylist, int appointmentduration, int advancebookingdays, string agentlist, int enablescheduling)

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

        private int _number_of_agents = 0;
        public int number_of_agents
        {
            get { return data._number_of_agents; }
            set { data._number_of_agents = value; }
        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        private int _appointment_duration = 0;
        public int appointment_duration
        {
            get { return data._appointment_duration; }
            set { data._appointment_duration = value; }
        }

        private int _advance_booking_days = 0;
        public int advance_booking_days
        {
            get { return data._advance_booking_days; }
            set { data._advance_booking_days = value; }
        }

        public string agent_list
        {
            get { return data.agent_list; }
            set { data.agent_list = value; }
        }

        private int _enable_scheduling = 0;
        public int enable_scheduling
        {
            get { return data._enable_scheduling; }
            set { data._enable_scheduling = value; }
        }

        private int _email_reminders = 0;
        public int email_reminders
        {
            get { return data._email_reminders; }
            set { data._email_reminders = value; }
        }

        public string success_redirect_url
        {
            get { return data.success_redirect_url; }
            set { data.success_redirect_url = value; }
        }


    }

    //Enums go here

}