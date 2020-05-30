using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Workstation
{
    public class ERPWorkstation : ERPNextObjectBase
    {
        public ERPWorkstation() : this(new ERPObject(DocType.Workstation)) { }
        public ERPWorkstation(ERPObject obj) : base(obj) { }

        public static ERPWorkstation Create(string workstationname, int productioncapacity)

        {
            ERPWorkstation obj = new ERPWorkstation();
            obj.workstation_name = workstationname;
            obj.production_capacity = productioncapacity;
            return obj;
        }

        public string workstation_name
        {
            get { return data.workstation_name; }
            set
            {
                data.workstation_name = value;
                data.name = value;
            }

        }

        private int _production_capacity = 0;
        public int production_capacity
        {
            get { return data._production_capacity; }
            set { data._production_capacity = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private double _hour_rate_electricity = 0.0;
        public double hour_rate_electricity
        {
            get { return data._hour_rate_electricity; }
            set { data._hour_rate_electricity = value; }
        }

        private double _hour_rate_consumable = 0.0;
        public double hour_rate_consumable
        {
            get { return data._hour_rate_consumable; }
            set { data._hour_rate_consumable = value; }
        }

        private double _hour_rate_rent = 0.0;
        public double hour_rate_rent
        {
            get { return data._hour_rate_rent; }
            set { data._hour_rate_rent = value; }
        }

        private double _hour_rate_labour = 0.0;
        public double hour_rate_labour
        {
            get { return data._hour_rate_labour; }
            set { data._hour_rate_labour = value; }
        }

        private double _hour_rate = 0.0;
        public double hour_rate
        {
            get { return data._hour_rate; }
            set { data._hour_rate = value; }
        }

        public string working_hours
        {
            get { return data.working_hours; }
            set { data.working_hours = value; }
        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }


    }

    //Enums go here

}