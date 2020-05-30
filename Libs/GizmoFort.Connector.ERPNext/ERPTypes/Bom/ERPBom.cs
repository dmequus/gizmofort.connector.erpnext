using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom
{
    public class ERPBom : ERPNextObjectBase
    {
        public ERPBom() : this(new ERPObject(DocType.Bom)) { }
        public ERPBom(ERPObject obj) : base(obj) { }

        public static ERPBom Create(string item, double quantity, string company, double conversionrate, string currency, string items)

        {
            ERPBom obj = new ERPBom();
            obj.item = item;
            obj.quantity = quantity;
            obj.company = company;
            obj.conversion_rate = conversionrate;
            obj.currency = currency;
            obj.items = items;
            return obj;
        }

        public string item
        {
            get { return data.item; }
            set
            {
                data.item = value;
                data.name = value;
            }

        }

        private double _quantity = 0.0;
        public double quantity
        {
            get { return data._quantity; }
            set { data._quantity = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private double _conversion_rate = 0.0;
        public double conversion_rate
        {
            get { return data._conversion_rate; }
            set { data._conversion_rate = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
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

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        private int _is_active = 0;
        public int is_active
        {
            get { return data._is_active; }
            set { data._is_active = value; }
        }

        private int _is_default = 0;
        public int is_default
        {
            get { return data._is_default; }
            set { data._is_default = value; }
        }

        private int _with_operations = 0;
        public int with_operations
        {
            get { return data._with_operations; }
            set { data._with_operations = value; }
        }

        private int _inspection_required = 0;
        public int inspection_required
        {
            get { return data._inspection_required; }
            set { data._inspection_required = value; }
        }

        private int _allow_alternative_item = 0;
        public int allow_alternative_item
        {
            get { return data._allow_alternative_item; }
            set { data._allow_alternative_item = value; }
        }

        private int _seta_rate_of_sub_assembly_item_based_on_bom = 0;
        public int seta_rate_of_sub_assembly_item_based_on_bom
        {
            get { return data._seta_rate_of_sub_assembly_item_based_on_bom; }
            set { data._seta_rate_of_sub_assembly_item_based_on_bom = value; }
        }

        public string quality_inspection_template
        {
            get { return data.quality_inspection_template; }
            set { data.quality_inspection_template = value; }
        }

        public Transfermaterialagainst transfer_material_against
        {
            get { return parseEnum<Transfermaterialagainst>(data.transfer_material_against); }
            set { data.transfer_material_against = value.ToString(); }
        }

        public Rmcostasper rm_cost_as_per
        {
            get { return parseEnum<Rmcostasper>(data.rm_cost_as_per); }
            set { data.rm_cost_as_per = value.ToString(); }
        }

        public string buying_price_list
        {
            get { return data.buying_price_list; }
            set { data.buying_price_list = value; }
        }

        public string routing
        {
            get { return data.routing; }
            set { data.routing = value; }
        }

        public string operations
        {
            get { return data.operations; }
            set { data.operations = value; }
        }

        public string scrap_items
        {
            get { return data.scrap_items; }
            set { data.scrap_items = value; }
        }

        private double _operating_cost = 0.0;
        public double operating_cost
        {
            get { return data._operating_cost; }
            set { data._operating_cost = value; }
        }

        private double _raw_material_cost = 0.0;
        public double raw_material_cost
        {
            get { return data._raw_material_cost; }
            set { data._raw_material_cost = value; }
        }

        private double _scrap_material_cost = 0.0;
        public double scrap_material_cost
        {
            get { return data._scrap_material_cost; }
            set { data._scrap_material_cost = value; }
        }

        private double _base_operating_cost = 0.0;
        public double base_operating_cost
        {
            get { return data._base_operating_cost; }
            set { data._base_operating_cost = value; }
        }

        private double _base_raw_material_cost = 0.0;
        public double base_raw_material_cost
        {
            get { return data._base_raw_material_cost; }
            set { data._base_raw_material_cost = value; }
        }

        private double _base_scrap_material_cost = 0.0;
        public double base_scrap_material_cost
        {
            get { return data._base_scrap_material_cost; }
            set { data._base_scrap_material_cost = value; }
        }

        private double _total_cost = 0.0;
        public double total_cost
        {
            get { return data._total_cost; }
            set { data._total_cost = value; }
        }

        private double _base_total_cost = 0.0;
        public double base_total_cost
        {
            get { return data._base_total_cost; }
            set { data._base_total_cost = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string exploded_items
        {
            get { return data.exploded_items; }
            set { data.exploded_items = value; }
        }

        private int _show_in_website = 0;
        public int show_in_website
        {
            get { return data._show_in_website; }
            set { data._show_in_website = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        public string website_image
        {
            get { return data.website_image; }
            set { data.website_image = value; }
        }

        public string thumbnail
        {
            get { return data.thumbnail; }
            set { data.thumbnail = value; }
        }

        public string web_long_description
        {
            get { return data.web_long_description; }
            set { data.web_long_description = value; }
        }

        private int _show_items = 0;
        public int show_items
        {
            get { return data._show_items; }
            set { data._show_items = value; }
        }

        private int _show_operations = 0;
        public int show_operations
        {
            get { return data._show_operations; }
            set { data._show_operations = value; }
        }

        private double _plc_conversion_rate = 0.0;
        public double plc_conversion_rate
        {
            get { return data._plc_conversion_rate; }
            set { data._plc_conversion_rate = value; }
        }

        public string price_list_currency
        {
            get { return data.price_list_currency; }
            set { data.price_list_currency = value; }
        }

        private int _has_variants = 0;
        public int has_variants
        {
            get { return data._has_variants; }
            set { data._has_variants = value; }
        }


    }

    //Enums go here
    public enum Transfermaterialagainst
    {
        [Description("Work Order")]
        WorkOrder,
        [Description("Job Card")]
        JobCard,
    }

    public enum Rmcostasper
    {
        [Description("Valuation Rate")]
        ValuationRate,
        [Description("Last Purchase Rate")]
        LastPurchaseRate,
        [Description("Price List")]
        PriceList,
    }


}