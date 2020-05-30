using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Vehicle_log
{
    public class ERPVehicle_log : ERPNextObjectBase
    {
        public ERPVehicle_log() : this(new ERPObject(DocType.Vehicle_log)) { }
        public ERPVehicle_log(ERPObject obj) : base(obj) { }

        public static ERPVehicle_log Create(string namingseries, string licenseplate, string employee, string date, int odometer, int lastodometer)

        {
            ERPVehicle_log obj = new ERPVehicle_log();
            obj.naming_series = namingseries;
            obj.license_plate = licenseplate;
            obj.employee = employee;
            obj.date = date;
            obj.odometer = odometer;
            obj.last_odometer = lastodometer;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string license_plate
        {
            get { return data.license_plate; }
            set { data.license_plate = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public int odometer
        {
            get { return data.odometer; }
            set { data.odometer = value; }
        }

        public int last_odometer
        {
            get { return data.last_odometer; }
            set { data.last_odometer = value; }
        }

        public string model
        {
            get { return data.model; }
            set { data.model = value; }
        }

        public string make
        {
            get { return data.make; }
            set { data.make = value; }
        }

        public double fuel_qty
        {
            get { return data.fuel_qty; }
            set { data.fuel_qty = value; }
        }

        public double price
        {
            get { return data.price; }
            set { data.price = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string invoice
        {
            get { return data.invoice; }
            set { data.invoice = value; }
        }

        public string service_detail
        {
            get { return data.service_detail; }
            set { data.service_detail = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}