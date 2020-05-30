using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_type
{
    public class ERPAppointment_type : ERPNextObjectBase
    {
        public ERPAppointment_type() : this(new ERPObject(DocType.Appointment_type)) { }
        public ERPAppointment_type(ERPObject obj) : base(obj) { }

        public static ERPAppointment_type Create(string appointmenttype)

        {
            ERPAppointment_type obj = new ERPAppointment_type();
            obj.appointment_type = appointmenttype;
            return obj;
        }

        public string appointment_type
        {
            get { return data.appointment_type; }
            set
            {
                data.appointment_type = value;
                data.name = value;
            }

        }

        public long ip
        {
            get { return data.ip; }
            set { data.ip = value; }
        }

        public int default_duration
        {
            get { return data.default_duration; }
            set { data.default_duration = value; }
        }

        public string color
        {
            get { return data.color; }
            set { data.color = value; }
        }


    }

    //Enums go here

}