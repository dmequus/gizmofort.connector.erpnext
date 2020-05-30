using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Practitioner_schedule
{
    public class ERPPractitioner_schedule : ERPNextObjectBase
    {
        public ERPPractitioner_schedule() : this(new ERPObject(DocType.Practitioner_schedule)) { }
        public ERPPractitioner_schedule(ERPObject obj) : base(obj) { }

        public static ERPPractitioner_schedule Create(string schedulename)

        {
            ERPPractitioner_schedule obj = new ERPPractitioner_schedule();
            obj.schedule_name = schedulename;
            return obj;
        }

        public string schedule_name
        {
            get { return data.schedule_name; }
            set
            {
                data.schedule_name = value;
                data.name = value;
            }

        }

        public string time_slots
        {
            get { return data.time_slots; }
            set { data.time_slots = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }


    }

    //Enums go here

}