using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_operation
{
    public class ERPBom_operation : ERPNextObjectBase
    {
        public ERPBom_operation() : this(new ERPObject(DocType.Bom_operation)) { }
        public ERPBom_operation(ERPObject obj) : base(obj) { }

        public static ERPBom_operation Create(string operation, double timeinmins)

        {
            ERPBom_operation obj = new ERPBom_operation();
            obj.operation = operation;
            obj.time_in_mins = timeinmins;
            return obj;
        }

        public string operation
        {
            get { return data.operation; }
            set
            {
                data.operation = value;
                data.name = value;
            }

        }

        private double _time_in_mins = 0.0;
        public double time_in_mins
        {
            get { return data._time_in_mins; }
            set { data._time_in_mins = value; }
        }

        public string workstation
        {
            get { return data.workstation; }
            set { data.workstation = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private double _hour_rate = 0.0;
        public double hour_rate
        {
            get { return data._hour_rate; }
            set { data._hour_rate = value; }
        }

        private double _operating_cost = 0.0;
        public double operating_cost
        {
            get { return data._operating_cost; }
            set { data._operating_cost = value; }
        }

        private double _base_hour_rate = 0.0;
        public double base_hour_rate
        {
            get { return data._base_hour_rate; }
            set { data._base_hour_rate = value; }
        }

        private double _base_operating_cost = 0.0;
        public double base_operating_cost
        {
            get { return data._base_operating_cost; }
            set { data._base_operating_cost = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        private int _batch_size = 0;
        public int batch_size
        {
            get { return data._batch_size; }
            set { data._batch_size = value; }
        }


    }

    //Enums go here

}