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

        public int production_capacity
        {
            get { return data.production_capacity; }
            set { data.production_capacity = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public double hour_rate_electricity
        {
            get { return data.hour_rate_electricity; }
            set { data.hour_rate_electricity = value; }
        }

        public double hour_rate_consumable
        {
            get { return data.hour_rate_consumable; }
            set { data.hour_rate_consumable = value; }
        }

        public double hour_rate_rent
        {
            get { return data.hour_rate_rent; }
            set { data.hour_rate_rent = value; }
        }

        public double hour_rate_labour
        {
            get { return data.hour_rate_labour; }
            set { data.hour_rate_labour = value; }
        }

        public double hour_rate
        {
            get { return data.hour_rate; }
            set { data.hour_rate = value; }
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