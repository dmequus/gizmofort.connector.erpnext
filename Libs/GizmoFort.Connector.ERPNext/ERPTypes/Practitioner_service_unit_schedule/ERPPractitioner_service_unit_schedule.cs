using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Practitioner_service_unit_schedule
{
    public class ERPPractitioner_service_unit_schedule : ERPNextObjectBase
    {
        public ERPPractitioner_service_unit_schedule() : this(new ERPObject(DocType.Practitioner_service_unit_schedule)) { }
        public ERPPractitioner_service_unit_schedule(ERPObject obj) : base(obj) { }

        public static ERPPractitioner_service_unit_schedule Create(string schedule, string serviceunit)

        {
            ERPPractitioner_service_unit_schedule obj = new ERPPractitioner_service_unit_schedule();
            obj.schedule = schedule;
            obj.service_unit = serviceunit;
            return obj;
        }

        public string schedule
        {
            get { return data.schedule; }
            set
            {
                data.schedule = value;
                data.name = value;
            }

        }

        public string service_unit
        {
            get { return data.service_unit; }
            set { data.service_unit = value; }
        }


    }

    //Enums go here

}