using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_card
{
    public class ERPJob_card : ERPNextObjectBase
    {
        public ERPJob_card() : this(new ERPObject(DocType.Job_card)) { }
        public ERPJob_card(ERPObject obj) : base(obj) { }

        public static ERPJob_card Create(string operation, string workorder, string workstation, string company, string wipwarehouse, string namingseries)

        {
            ERPJob_card obj = new ERPJob_card();
            obj.operation = operation;
            obj.work_order = workorder;
            obj.workstation = workstation;
            obj.company = company;
            obj.wip_warehouse = wipwarehouse;
            obj.naming_series = namingseries;
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

        public string work_order
        {
            get { return data.work_order; }
            set { data.work_order = value; }
        }

        public string workstation
        {
            get { return data.workstation; }
            set { data.workstation = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string wip_warehouse
        {
            get { return data.wip_warehouse; }
            set { data.wip_warehouse = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string bom_no
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public double for_quantity
        {
            get { return data.for_quantity; }
            set { data.for_quantity = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string time_logs
        {
            get { return data.time_logs; }
            set { data.time_logs = value; }
        }

        public double total_completed_qty
        {
            get { return data.total_completed_qty; }
            set { data.total_completed_qty = value; }
        }

        public double total_time_in_mins
        {
            get { return data.total_time_in_mins; }
            set { data.total_time_in_mins = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string operation_id
        {
            get { return data.operation_id; }
            set { data.operation_id = value; }
        }

        public double transferred_qty
        {
            get { return data.transferred_qty; }
            set { data.transferred_qty = value; }
        }

        public double requested_qty
        {
            get { return data.requested_qty; }
            set { data.requested_qty = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public long job_started
        {
            get { return data.job_started; }
            set { data.job_started = value; }
        }

        public string started_time
        {
            get { return data.started_time; }
            set { data.started_time = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        public string production_item
        {
            get { return data.production_item; }
            set { data.production_item = value; }
        }

        public string barcode
        {
            get { return data.barcode; }
            set { data.barcode = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public int current_time
        {
            get { return data.current_time; }
            set { data.current_time = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Work In Progress")]
        WorkInProgress,
        [Description("Material Transferred")]
        MaterialTransferred,
        [Description("On Hold")]
        OnHold,
        [Description("Submitted")]
        Submitted,
        [Description("Cancelled")]
        Cancelled,
        [Description("Completed")]
        Completed,
    }


}