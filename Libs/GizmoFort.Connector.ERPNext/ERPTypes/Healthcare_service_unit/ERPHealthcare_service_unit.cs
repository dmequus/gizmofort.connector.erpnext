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

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        public string service_unit_type
        {
            get { return data.service_unit_type; }
            set { data.service_unit_type = value; }
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

        public int lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        public int rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
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