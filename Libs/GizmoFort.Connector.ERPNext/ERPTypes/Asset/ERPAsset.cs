using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset
{
    public class ERPAsset : ERPNextObjectBase
    {
        public ERPAsset() : this(new ERPObject(DocType.Asset)) { }
        public ERPAsset(ERPObject obj) : base(obj) { }

        public static ERPAsset Create(string assetname, string itemcode, string company, string location, string purchasedate, double grosspurchaseamount)

        {
            ERPAsset obj = new ERPAsset();
            obj.asset_name = assetname;
            obj.item_code = itemcode;
            obj.company = company;
            obj.location = location;
            obj.purchase_date = purchasedate;
            obj.gross_purchase_amount = grosspurchaseamount;
            return obj;
        }

        public string asset_name
        {
            get { return data.asset_name; }
            set
            {
                data.asset_name = value;
                data.name = value;
            }

        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string location
        {
            get { return data.location; }
            set { data.location = value; }
        }

        public string purchase_date
        {
            get { return data.purchase_date; }
            set { data.purchase_date = value; }
        }

        public double gross_purchase_amount
        {
            get { return data.gross_purchase_amount; }
            set { data.gross_purchase_amount = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string asset_category
        {
            get { return data.asset_category; }
            set { data.asset_category = value; }
        }

        public Assetowner asset_owner
        {
            get { return parseEnum<Assetowner>(data.asset_owner); }
            set { data.asset_owner = value.ToString(); }
        }

        public string asset_owner_company
        {
            get { return data.asset_owner_company; }
            set { data.asset_owner_company = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string custodian
        {
            get { return data.custodian; }
            set { data.custodian = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string disposal_date
        {
            get { return data.disposal_date; }
            set { data.disposal_date = value; }
        }

        public string journal_entry_for_scrap
        {
            get { return data.journal_entry_for_scrap; }
            set { data.journal_entry_for_scrap = value; }
        }

        public string available_for_use_date
        {
            get { return data.available_for_use_date; }
            set { data.available_for_use_date = value; }
        }

        public long calculate_depreciation
        {
            get { return data.calculate_depreciation; }
            set { data.calculate_depreciation = value; }
        }

        public long is_existing_asset
        {
            get { return data.is_existing_asset; }
            set { data.is_existing_asset = value; }
        }

        public double opening_accumulated_depreciation
        {
            get { return data.opening_accumulated_depreciation; }
            set { data.opening_accumulated_depreciation = value; }
        }

        public int number_of_depreciations_booked
        {
            get { return data.number_of_depreciations_booked; }
            set { data.number_of_depreciations_booked = value; }
        }

        public string finance_books
        {
            get { return data.finance_books; }
            set { data.finance_books = value; }
        }

        public Depreciationmethod depreciation_method
        {
            get { return parseEnum<Depreciationmethod>(data.depreciation_method); }
            set { data.depreciation_method = value.ToString(); }
        }

        public double value_after_depreciation
        {
            get { return data.value_after_depreciation; }
            set { data.value_after_depreciation = value; }
        }

        public int total_number_of_depreciations
        {
            get { return data.total_number_of_depreciations; }
            set { data.total_number_of_depreciations = value; }
        }

        public int frequency_of_depreciation
        {
            get { return data.frequency_of_depreciation; }
            set { data.frequency_of_depreciation = value; }
        }

        public string next_depreciation_date
        {
            get { return data.next_depreciation_date; }
            set { data.next_depreciation_date = value; }
        }

        public string schedules
        {
            get { return data.schedules; }
            set { data.schedules = value; }
        }

        public string policy_number
        {
            get { return data.policy_number; }
            set { data.policy_number = value; }
        }

        public string insurer
        {
            get { return data.insurer; }
            set { data.insurer = value; }
        }

        public string insured_value
        {
            get { return data.insured_value; }
            set { data.insured_value = value; }
        }

        public string insurance_start_date
        {
            get { return data.insurance_start_date; }
            set { data.insurance_start_date = value; }
        }

        public string insurance_end_date
        {
            get { return data.insurance_end_date; }
            set { data.insurance_end_date = value; }
        }

        public string comprehensive_insurance
        {
            get { return data.comprehensive_insurance; }
            set { data.comprehensive_insurance = value; }
        }

        public long maintenance_required
        {
            get { return data.maintenance_required; }
            set { data.maintenance_required = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public long booked_fixed_asset
        {
            get { return data.booked_fixed_asset; }
            set { data.booked_fixed_asset = value; }
        }

        public string purchase_receipt
        {
            get { return data.purchase_receipt; }
            set { data.purchase_receipt = value; }
        }

        public double purchase_receipt_amount
        {
            get { return data.purchase_receipt_amount; }
            set { data.purchase_receipt_amount = value; }
        }

        public string purchase_invoice
        {
            get { return data.purchase_invoice; }
            set { data.purchase_invoice = value; }
        }

        public string default_finance_book
        {
            get { return data.default_finance_book; }
            set { data.default_finance_book = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public long allow_monthly_depreciation
        {
            get { return data.allow_monthly_depreciation; }
            set { data.allow_monthly_depreciation = value; }
        }


    }

    //Enums go here
    public enum Assetowner
    {
        [Description("Company")]
        Company,
        [Description("Supplier")]
        Supplier,
        [Description("Customer")]
        Customer,
    }

    public enum Depreciationmethod
    {
        [Description("Straight Line")]
        StraightLine,
        [Description("Double Declining Balance")]
        DoubleDecliningBalance,
        [Description("Manual")]
        Manual,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Partially Depreciated")]
        PartiallyDepreciated,
        [Description("Fully Depreciated")]
        FullyDepreciated,
        [Description("Sold")]
        Sold,
        [Description("Scrapped")]
        Scrapped,
        [Description("In Maintenance")]
        InMaintenance,
        [Description("Out of Order")]
        OutofOrder,
        [Description("Issue")]
        Issue,
        [Description("Receipt")]
        Receipt,
    }


}