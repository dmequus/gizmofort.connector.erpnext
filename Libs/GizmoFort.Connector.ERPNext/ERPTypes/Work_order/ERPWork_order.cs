using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Work_order
{
    public class ERPWork_order : ERPNextObjectBase
    {
        public ERPWork_order() : this(new ERPObject(DocType.Work_order)) { }
        public ERPWork_order(ERPObject obj) : base(obj) { }

        public static ERPWork_order Create(string productionitem, string namingseries, Status status, string bomno, string company, double qty, string fgwarehouse, string plannedstartdate)

        {
            ERPWork_order obj = new ERPWork_order();
            obj.production_item = productionitem;
            obj.naming_series = namingseries;
            obj.status = status;
            obj.bom_no = bomno;
            obj.company = company;
            obj.qty = qty;
            obj.fg_warehouse = fgwarehouse;
            obj.planned_start_date = plannedstartdate;
            return obj;
        }

        public string production_item
        {
            get { return data.production_item; }
            set
            {
                data.production_item = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string bom_no
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        public string fg_warehouse
        {
            get { return data.fg_warehouse; }
            set { data.fg_warehouse = value; }
        }

        public string planned_start_date
        {
            get { return data.planned_start_date; }
            set { data.planned_start_date = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        private int _allow_alternative_item = 0;
        public int allow_alternative_item
        {
            get { return data._allow_alternative_item; }
            set { data._allow_alternative_item = value; }
        }

        private int _use_multi_level_bom = 0;
        public int use_multi_level_bom
        {
            get { return data._use_multi_level_bom; }
            set { data._use_multi_level_bom = value; }
        }

        private int _skip_transfer = 0;
        public int skip_transfer
        {
            get { return data._skip_transfer; }
            set { data._skip_transfer = value; }
        }

        private double _material_transferred_for_manufacturing = 0.0;
        public double material_transferred_for_manufacturing
        {
            get { return data._material_transferred_for_manufacturing; }
            set { data._material_transferred_for_manufacturing = value; }
        }

        private double _produced_qty = 0.0;
        public double produced_qty
        {
            get { return data._produced_qty; }
            set { data._produced_qty = value; }
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        private int _from_wip_warehouse = 0;
        public int from_wip_warehouse
        {
            get { return data._from_wip_warehouse; }
            set { data._from_wip_warehouse = value; }
        }

        public string wip_warehouse
        {
            get { return data.wip_warehouse; }
            set { data.wip_warehouse = value; }
        }

        public string scrap_warehouse
        {
            get { return data.scrap_warehouse; }
            set { data.scrap_warehouse = value; }
        }

        public string required_items
        {
            get { return data.required_items; }
            set { data.required_items = value; }
        }

        public string actual_start_date
        {
            get { return data.actual_start_date; }
            set { data.actual_start_date = value; }
        }

        public string planned_end_date
        {
            get { return data.planned_end_date; }
            set { data.planned_end_date = value; }
        }

        public string actual_end_date
        {
            get { return data.actual_end_date; }
            set { data.actual_end_date = value; }
        }

        public string expected_delivery_date
        {
            get { return data.expected_delivery_date; }
            set { data.expected_delivery_date = value; }
        }

        public Transfermaterialagainst transfer_material_against
        {
            get { return parseEnum<Transfermaterialagainst>(data.transfer_material_against); }
            set { data.transfer_material_against = value.ToString(); }
        }

        public string operations
        {
            get { return data.operations; }
            set { data.operations = value; }
        }

        private double _planned_operating_cost = 0.0;
        public double planned_operating_cost
        {
            get { return data._planned_operating_cost; }
            set { data._planned_operating_cost = value; }
        }

        private double _actual_operating_cost = 0.0;
        public double actual_operating_cost
        {
            get { return data._actual_operating_cost; }
            set { data._actual_operating_cost = value; }
        }

        private double _additional_operating_cost = 0.0;
        public double additional_operating_cost
        {
            get { return data._additional_operating_cost; }
            set { data._additional_operating_cost = value; }
        }

        private double _total_operating_cost = 0.0;
        public double total_operating_cost
        {
            get { return data._total_operating_cost; }
            set { data._total_operating_cost = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public string material_request
        {
            get { return data.material_request; }
            set { data.material_request = value; }
        }

        public string material_request_item
        {
            get { return data.material_request_item; }
            set { data.material_request_item = value; }
        }

        public string sales_order_item
        {
            get { return data.sales_order_item; }
            set { data.sales_order_item = value; }
        }

        public string production_plan
        {
            get { return data.production_plan; }
            set { data.production_plan = value; }
        }

        public string production_plan_item
        {
            get { return data.production_plan_item; }
            set { data.production_plan_item = value; }
        }

        public string product_bundle_item
        {
            get { return data.product_bundle_item; }
            set { data.product_bundle_item = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        private int _update_consumed_material_cost_in_project = 0;
        public int update_consumed_material_cost_in_project
        {
            get { return data._update_consumed_material_cost_in_project; }
            set { data._update_consumed_material_cost_in_project = value; }
        }

        public string source_warehouse
        {
            get { return data.source_warehouse; }
            set { data.source_warehouse = value; }
        }

        private double _lead_time = 0.0;
        public double lead_time
        {
            get { return data._lead_time; }
            set { data._lead_time = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Not Started")]
        NotStarted,
        [Description("In Process")]
        InProcess,
        [Description("Completed")]
        Completed,
        [Description("Stopped")]
        Stopped,
        [Description("Cancelled")]
        Cancelled,
    }

    public enum Transfermaterialagainst
    {
        [Description("Work Order")]
        WorkOrder,
        [Description("Job Card")]
        JobCard,
    }


}