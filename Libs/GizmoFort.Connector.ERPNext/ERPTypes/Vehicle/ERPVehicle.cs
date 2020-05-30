using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Vehicle
{
    public class ERPVehicle : ERPNextObjectBase
    {
        public ERPVehicle() : this(new ERPObject(DocType.Vehicle)) { }
        public ERPVehicle(ERPObject obj) : base(obj) { }

        public static ERPVehicle Create(string licenseplate, string make, string model, int lastodometer, string acquisitiondate, string location, string chassisno, double vehiclevalue, string employee, string insurancecompany, string policyno, string startdate, string enddate, Fueltype fueltype, string uom, string carboncheckdate, string color, int wheels, int doors, string amendedfrom)

        {
            ERPVehicle obj = new ERPVehicle();
            obj.license_plate = licenseplate;
            obj.make = make;
            obj.model = model;
            obj.last_odometer = lastodometer;
            obj.acquisition_date = acquisitiondate;
            obj.location = location;
            obj.chassis_no = chassisno;
            obj.vehicle_value = vehiclevalue;
            obj.employee = employee;
            obj.insurance_company = insurancecompany;
            obj.policy_no = policyno;
            obj.start_date = startdate;
            obj.end_date = enddate;
            obj.fuel_type = fueltype;
            obj.uom = uom;
            obj.carbon_check_date = carboncheckdate;
            obj.color = color;
            obj.wheels = wheels;
            obj.doors = doors;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string license_plate
        {
            get { return data.license_plate; }
            set
            {
                data.license_plate = value;
                data.name = value;
            }

        }

        public string make
        {
            get { return data.make; }
            set { data.make = value; }
        }

        public string model
        {
            get { return data.model; }
            set { data.model = value; }
        }

        private int _last_odometer = 0;
        public int last_odometer
        {
            get { return data._last_odometer; }
            set { data._last_odometer = value; }
        }

        public string acquisition_date
        {
            get { return data.acquisition_date; }
            set { data.acquisition_date = value; }
        }

        public string location
        {
            get { return data.location; }
            set { data.location = value; }
        }

        public string chassis_no
        {
            get { return data.chassis_no; }
            set { data.chassis_no = value; }
        }

        private double _vehicle_value = 0.0;
        public double vehicle_value
        {
            get { return data._vehicle_value; }
            set { data._vehicle_value = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string insurance_company
        {
            get { return data.insurance_company; }
            set { data.insurance_company = value; }
        }

        public string policy_no
        {
            get { return data.policy_no; }
            set { data.policy_no = value; }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public Fueltype fuel_type
        {
            get { return parseEnum<Fueltype>(data.fuel_type); }
            set { data.fuel_type = value.ToString(); }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public string carbon_check_date
        {
            get { return data.carbon_check_date; }
            set { data.carbon_check_date = value; }
        }

        public string color
        {
            get { return data.color; }
            set { data.color = value; }
        }

        private int _wheels = 0;
        public int wheels
        {
            get { return data._wheels; }
            set { data._wheels = value; }
        }

        private int _doors = 0;
        public int doors
        {
            get { return data._doors; }
            set { data._doors = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Fueltype
    {
        [Description("Petrol")]
        Petrol,
        [Description("Diesel")]
        Diesel,
        [Description("Natural Gas")]
        NaturalGas,
        [Description("Electric")]
        Electric,
    }


}