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

        private int _allow_appointments = 0;
        public int allow_appointments
        {
            get { return data._allow_appointments; }
            set { data._allow_appointments = value; }
        }

        private int _overlap_appointments = 0;
        public int overlap_appointments
        {
            get { return data._overlap_appointments; }
            set { data._overlap_appointments = value; }
        }

        private int _inpatient_occupancy = 0;
        public int inpatient_occupancy
        {
            get { return data._inpatient_occupancy; }
            set { data._inpatient_occupancy = value; }
        }

        private int _is_billable = 0;
        public int is_billable
        {
            get { return data._is_billable; }
            set { data._is_billable = value; }
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

        private int _no_of_hours = 0;
        public int no_of_hours
        {
            get { return data._no_of_hours; }
            set { data._no_of_hours = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private int _change_in_item = 0;
        public int change_in_item
        {
            get { return data._change_in_item; }
            set { data._change_in_item = value; }
        }


    }

    //Enums go here

}