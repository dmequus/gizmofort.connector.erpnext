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

        public double time_in_mins
        {
            get { return data.time_in_mins; }
            set { data.time_in_mins = value; }
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

        public double hour_rate
        {
            get { return data.hour_rate; }
            set { data.hour_rate = value; }
        }

        public double operating_cost
        {
            get { return data.operating_cost; }
            set { data.operating_cost = value; }
        }

        public double base_hour_rate
        {
            get { return data.base_hour_rate; }
            set { data.base_hour_rate = value; }
        }

        public double base_operating_cost
        {
            get { return data.base_operating_cost; }
            set { data.base_operating_cost = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public int batch_size
        {
            get { return data.batch_size; }
            set { data.batch_size = value; }
        }


    }

    //Enums go here

}