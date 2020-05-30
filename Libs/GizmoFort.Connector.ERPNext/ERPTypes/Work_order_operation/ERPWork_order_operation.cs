using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Work_order_operation
{
    public class ERPWork_order_operation : ERPNextObjectBase
    {
        public ERPWork_order_operation() : this(new ERPObject(DocType.Work_order_operation)) { }
        public ERPWork_order_operation(ERPObject obj) : base(obj) { }

        public static ERPWork_order_operation Create(string operation, double timeinmins)

        {
            ERPWork_order_operation obj = new ERPWork_order_operation();
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

        public string bom
        {
            get { return data.bom; }
            set { data.bom = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public double completed_qty
        {
            get { return data.completed_qty; }
            set { data.completed_qty = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string workstation
        {
            get { return data.workstation; }
            set { data.workstation = value; }
        }

        public string planned_start_time
        {
            get { return data.planned_start_time; }
            set { data.planned_start_time = value; }
        }

        public string planned_end_time
        {
            get { return data.planned_end_time; }
            set { data.planned_end_time = value; }
        }

        public double hour_rate
        {
            get { return data.hour_rate; }
            set { data.hour_rate = value; }
        }

        public double planned_operating_cost
        {
            get { return data.planned_operating_cost; }
            set { data.planned_operating_cost = value; }
        }

        public string actual_start_time
        {
            get { return data.actual_start_time; }
            set { data.actual_start_time = value; }
        }

        public string actual_end_time
        {
            get { return data.actual_end_time; }
            set { data.actual_end_time = value; }
        }

        public double actual_operation_time
        {
            get { return data.actual_operation_time; }
            set { data.actual_operation_time = value; }
        }

        public double actual_operating_cost
        {
            get { return data.actual_operating_cost; }
            set { data.actual_operating_cost = value; }
        }

        public int batch_size
        {
            get { return data.batch_size; }
            set { data.batch_size = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Pending")]
        Pending,
        [Description("Work in Progress")]
        WorkinProgress,
        [Description("Completed")]
        Completed,
    }


}