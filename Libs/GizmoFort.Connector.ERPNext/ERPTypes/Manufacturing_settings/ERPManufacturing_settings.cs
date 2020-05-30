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

        private int _allow_overtime = 0;
        public int allow_overtime
        {
            get { return data._allow_overtime; }
            set { data._allow_overtime = value; }
        }

        private int _allow_production_on_holidays = 0;
        public int allow_production_on_holidays
        {
            get { return data._allow_production_on_holidays; }
            set { data._allow_production_on_holidays = value; }
        }

        private int _capacity_planning_for_days = 0;
        public int capacity_planning_for_days
        {
            get { return data._capacity_planning_for_days; }
            set { data._capacity_planning_for_days = value; }
        }

        private int _mins_between_operations = 0;
        public int mins_between_operations
        {
            get { return data._mins_between_operations; }
            set { data._mins_between_operations = value; }
        }

        private double _overproduction_percentage_for_sales_order = 0.0;
        public double overproduction_percentage_for_sales_order
        {
            get { return data._overproduction_percentage_for_sales_order; }
            set { data._overproduction_percentage_for_sales_order = value; }
        }

        private double _overproduction_percentage_for_work_order = 0.0;
        public double overproduction_percentage_for_work_order
        {
            get { return data._overproduction_percentage_for_work_order; }
            set { data._overproduction_percentage_for_work_order = value; }
        }

        public Backflushrawmaterialsbasedon backflush_raw_materials_based_on
        {
            get { return parseEnum<Backflushrawmaterialsbasedon>(data.backflush_raw_materials_based_on); }
            set { data.backflush_raw_materials_based_on = value.ToString(); }
        }

        private int _material_consumption = 0;
        public int material_consumption
        {
            get { return data._material_consumption; }
            set { data._material_consumption = value; }
        }

        private int _update_bom_costs_automatically = 0;
        public int update_bom_costs_automatically
        {
            get { return data._update_bom_costs_automatically; }
            set { data._update_bom_costs_automatically = value; }
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

        private int _disable_capacity_planning = 0;
        public int disable_capacity_planning
        {
            get { return data._disable_capacity_planning; }
            set { data._disable_capacity_planning = value; }
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