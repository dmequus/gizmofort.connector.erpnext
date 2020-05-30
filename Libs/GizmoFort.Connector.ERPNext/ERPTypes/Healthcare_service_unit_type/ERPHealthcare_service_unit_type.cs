using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_service_unit_type
{
    public class ERPHealthcare_service_unit_type : ERPNextObjectBase
    {
        public ERPHealthcare_service_unit_type() : this(new ERPObject(DocType.Healthcare_service_unit_type)) { }
        public ERPHealthcare_service_unit_type(ERPObject obj) : base(obj) { }

        public static ERPHealthcare_service_unit_type Create(string serviceunittype)

        {
            ERPHealthcare_service_unit_type obj = new ERPHealthcare_service_unit_type();
            obj.service_unit_type = serviceunittype;
            return obj;
        }

        public string service_unit_type
        {
            get { return data.service_unit_type; }
            set
            {
                data.service_unit_type = value;
                data.name = value;
            }

        }

        public long allow_appointments
        {
            get { return data.allow_appointments; }
            set { data.allow_appointments = value; }
        }

        public long overlap_appointments
        {
            get { return data.overlap_appointments; }
            set { data.overlap_appointments = value; }
        }

        public long inpatient_occupancy
        {
            get { return data.inpatient_occupancy; }
            set { data.inpatient_occupancy = value; }
        }

        public long is_billable
        {
            get { return data.is_billable; }
            set { data.is_billable = value; }
        }

        public string item
        {
            get { return data.item; }
            set { data.item = value; }
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public int no_of_hours
        {
            get { return data.no_of_hours; }
            set { data.no_of_hours = value; }
        }

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public long change_in_item
        {
            get { return data.change_in_item; }
            set { data.change_in_item = value; }
        }


    }

    //Enums go here

}