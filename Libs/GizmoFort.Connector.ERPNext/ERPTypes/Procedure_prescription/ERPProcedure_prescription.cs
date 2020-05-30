using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Procedure_prescription
{
    public class ERPProcedure_prescription : ERPNextObjectBase
    {
        public ERPProcedure_prescription() : this(new ERPObject(DocType.Procedure_prescription)) { }
        public ERPProcedure_prescription(ERPObject obj) : base(obj) { }

        public static ERPProcedure_prescription Create(string procedure)

        {
            ERPProcedure_prescription obj = new ERPProcedure_prescription();
            obj.procedure = procedure;
            return obj;
        }

        public string procedure
        {
            get { return data.procedure; }
            set
            {
                data.procedure = value;
                data.name = value;
            }

        }

        public string procedure_name
        {
            get { return data.procedure_name; }
            set { data.procedure_name = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string practitioner
        {
            get { return data.practitioner; }
            set { data.practitioner = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string comments
        {
            get { return data.comments; }
            set { data.comments = value; }
        }

        private int _appointment_booked = 0;
        public int appointment_booked
        {
            get { return data._appointment_booked; }
            set { data._appointment_booked = value; }
        }

        private int _procedure_created = 0;
        public int procedure_created
        {
            get { return data._procedure_created; }
            set { data._procedure_created = value; }
        }

        private int _invoiced = 0;
        public int invoiced
        {
            get { return data._invoiced; }
            set { data._invoiced = value; }
        }


    }

    //Enums go here

}