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

        public double quantity
        {
            get { return data.quantity; }
            set { data.quantity = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public double conversion_rate
        {
            get { return data.conversion_rate; }
            set { data.conversion_rate = value; }
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

        public long is_active
        {
            get { return data.is_active; }
            set { data.is_active = value; }
        }

        public long is_default
        {
            get { return data.is_default; }
            set { data.is_default = value; }
        }

        public long with_operations
        {
            get { return data.with_operations; }
            set { data.with_operations = value; }
        }

        public long inspection_required
        {
            get { return data.inspection_required; }
            set { data.inspection_required = value; }
        }

        public long allow_alternative_item
        {
            get { return data.allow_alternative_item; }
            set { data.allow_alternative_item = value; }
        }

        public long seta_rate_of_sub_assembly_item_based_on_bom
        {
            get { return data.seta_rate_of_sub_assembly_item_based_on_bom; }
            set { data.seta_rate_of_sub_assembly_item_based_on_bom = value; }
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

        public double operating_cost
        {
            get { return data.operating_cost; }
            set { data.operating_cost = value; }
        }

        public double raw_material_cost
        {
            get { return data.raw_material_cost; }
            set { data.raw_material_cost = value; }
        }

        public double scrap_material_cost
        {
            get { return data.scrap_material_cost; }
            set { data.scrap_material_cost = value; }
        }

        public double base_operating_cost
        {
            get { return data.base_operating_cost; }
            set { data.base_operating_cost = value; }
        }

        public double base_raw_material_cost
        {
            get { return data.base_raw_material_cost; }
            set { data.base_raw_material_cost = value; }
        }

        public double base_scrap_material_cost
        {
            get { return data.base_scrap_material_cost; }
            set { data.base_scrap_material_cost = value; }
        }

        public double total_cost
        {
            get { return data.total_cost; }
            set { data.total_cost = value; }
        }

        public double base_total_cost
        {
            get { return data.base_total_cost; }
            set { data.base_total_cost = value; }
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

        public long show_in_website
        {
            get { return data.show_in_website; }
            set { data.show_in_website = value; }
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

        public long show_items
        {
            get { return data.show_items; }
            set { data.show_items = value; }
        }

        public long show_operations
        {
            get { return data.show_operations; }
            set { data.show_operations = value; }
        }

        public double plc_conversion_rate
        {
            get { return data.plc_conversion_rate; }
            set { data.plc_conversion_rate = value; }
        }

        public string price_list_currency
        {
            get { return data.price_list_currency; }
            set { data.price_list_currency = value; }
        }

        public long has_variants
        {
            get { return data.has_variants; }
            set { data.has_variants = value; }
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