using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_letter_content
{
    public class ERPAppointment_letter_content : ERPNextObjectBase
    {
        public ERPAppointment_letter_content() : this(new ERPObject(DocType.Appointment_letter_content)) { }
        public ERPAppointment_letter_content(ERPObject obj) : base(obj) { }

        public static ERPAppointment_letter_content Create(string title, string description)

        {
            ERPAppointment_letter_content obj = new ERPAppointment_letter_content();
            obj.title = title;
            obj.description = description;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}