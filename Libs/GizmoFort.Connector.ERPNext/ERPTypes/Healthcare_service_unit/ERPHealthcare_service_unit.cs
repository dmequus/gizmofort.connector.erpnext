using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_service_unit
{
    public class ERPHealthcare_service_unit : ERPNextObjectBase
    {
        public ERPHealthcare_service_unit() : this(new ERPObject(DocType.Healthcare_service_unit)) { }
        public ERPHealthcare_service_unit(ERPObject obj) : base(obj) { }

        public static ERPHealthcare_service_unit Create(string healthcareserviceunitname, string company)

        {
            ERPHealthcare_service_unit obj = new ERPHealthcare_service_unit();
            obj.healthcare_service_unit_name = healthcareserviceunitname;
            obj.company = company;
            return obj;
        }

        public string healthcare_service_unit_name
        {
            get { return data.healthcare_service_unit_name; }
            set
            {
                data.healthcare_service_unit_name = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string parent_healthcare_service_unit
        {
            get { return data.parent_healthcare_service_unit; }
            set { data.parent_healthcare_service_unit = value; }
        }

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
        }

        public string service_unit_type
        {
            get { return data.service_unit_type; }
            set { data.service_unit_type = value; }
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

        public Occupancystatus occupancy_status
        {
            get { return parseEnum<Occupancystatus>(data.occupancy_status); }
            set { data.occupancy_status = value.ToString(); }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }


    }

    //Enums go here
    public enum Occupancystatus
    {
        [Description("Vacant")]
        Vacant,
        [Description("Occupied")]
        Occupied,
    }


}