using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing_settings
{
    public class ERPManufacturing_settings : ERPNextObjectBase
    {
        public ERPManufacturing_settings() : this(new ERPObject(DocType.Manufacturing_settings)) { }
        public ERPManufacturing_settings(ERPObject obj) : base(obj) { }

        public static ERPManufacturing_settings Create()

        {
            ERPManufacturing_settings obj = new ERPManufacturing_settings();
            return obj;
        }

        public long allow_overtime
        {
            get { return data.allow_overtime; }
            set { data.allow_overtime = value; }
        }

        public long allow_production_on_holidays
        {
            get { return data.allow_production_on_holidays; }
            set { data.allow_production_on_holidays = value; }
        }

        public int capacity_planning_for_days
        {
            get { return data.capacity_planning_for_days; }
            set { data.capacity_planning_for_days = value; }
        }

        public int mins_between_operations
        {
            get { return data.mins_between_operations; }
            set { data.mins_between_operations = value; }
        }

        public double overproduction_percentage_for_sales_order
        {
            get { return data.overproduction_percentage_for_sales_order; }
            set { data.overproduction_percentage_for_sales_order = value; }
        }

        public double overproduction_percentage_for_work_order
        {
            get { return data.overproduction_percentage_for_work_order; }
            set { data.overproduction_percentage_for_work_order = value; }
        }

        public Backflushrawmaterialsbasedon backflush_raw_materials_based_on
        {
            get { return parseEnum<Backflushrawmaterialsbasedon>(data.backflush_raw_materials_based_on); }
            set { data.backflush_raw_materials_based_on = value.ToString(); }
        }

        public long material_consumption
        {
            get { return data.material_consumption; }
            set { data.material_consumption = value; }
        }

        public long update_bom_costs_automatically
        {
            get { return data.update_bom_costs_automatically; }
            set { data.update_bom_costs_automatically = value; }
        }

        public string default_wip_warehouse
        {
            get { return data.default_wip_warehouse; }
            set { data.default_wip_warehouse = value; }
        }

        public string default_fg_warehouse
        {
            get { return data.default_fg_warehouse; }
            set { data.default_fg_warehouse = value; }
        }

        public long disable_capacity_planning
        {
            get { return data.disable_capacity_planning; }
            set { data.disable_capacity_planning = value; }
        }

        public string default_scrap_warehouse
        {
            get { return data.default_scrap_warehouse; }
            set { data.default_scrap_warehouse = value; }
        }


    }

    //Enums go here
    public enum Backflushrawmaterialsbasedon
    {
        [Description("BOM")]
        BOM,
        [Description("Material Transferred for Manufacture")]
        MaterialTransferredforManufacture,
    }


}