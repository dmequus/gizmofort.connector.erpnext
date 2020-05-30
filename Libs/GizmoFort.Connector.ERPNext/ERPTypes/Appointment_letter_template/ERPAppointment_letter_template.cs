using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_letter_template
{
    public class ERPAppointment_letter_template : ERPNextObjectBase
    {
        public ERPAppointment_letter_template() : this(new ERPObject(DocType.Appointment_letter_template)) { }
        public ERPAppointment_letter_template(ERPObject obj) : base(obj) { }

        public static ERPAppointment_letter_template Create(string introduction, string terms)

        {
            ERPAppointment_letter_template obj = new ERPAppointment_letter_template();
            obj.introduction = introduction;
            obj.terms = terms;
            return obj;
        }

        public string introduction
        {
            get { return data.introduction; }
            set
            {
                data.introduction = value;
                data.name = value;
            }

        }

        public string terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        public string closing_notes
        {
            get { return data.closing_notes; }
            set { data.closing_notes = value; }
        }


    }

    //Enums go here

}