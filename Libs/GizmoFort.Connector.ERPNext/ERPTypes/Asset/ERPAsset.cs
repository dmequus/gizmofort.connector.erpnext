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

        private double _gross_purchase_amount = 0.0;
        public double gross_purchase_amount
        {
            get { return data._gross_purchase_amount; }
            set { data._gross_purchase_amount = value; }
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

        private int _calculate_depreciation = 0;
        public int calculate_depreciation
        {
            get { return data._calculate_depreciation; }
            set { data._calculate_depreciation = value; }
        }

        private int _is_existing_asset = 0;
        public int is_existing_asset
        {
            get { return data._is_existing_asset; }
            set { data._is_existing_asset = value; }
        }

        private double _opening_accumulated_depreciation = 0.0;
        public double opening_accumulated_depreciation
        {
            get { return data._opening_accumulated_depreciation; }
            set { data._opening_accumulated_depreciation = value; }
        }

        private int _number_of_depreciations_booked = 0;
        public int number_of_depreciations_booked
        {
            get { return data._number_of_depreciations_booked; }
            set { data._number_of_depreciations_booked = value; }
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

        private double _value_after_depreciation = 0.0;
        public double value_after_depreciation
        {
            get { return data._value_after_depreciation; }
            set { data._value_after_depreciation = value; }
        }

        private int _total_number_of_depreciations = 0;
        public int total_number_of_depreciations
        {
            get { return data._total_number_of_depreciations; }
            set { data._total_number_of_depreciations = value; }
        }

        private int _frequency_of_depreciation = 0;
        public int frequency_of_depreciation
        {
            get { return data._frequency_of_depreciation; }
            set { data._frequency_of_depreciation = value; }
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

        private int _maintenance_required = 0;
        public int maintenance_required
        {
            get { return data._maintenance_required; }
            set { data._maintenance_required = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        private int _booked_fixed_asset = 0;
        public int booked_fixed_asset
        {
            get { return data._booked_fixed_asset; }
            set { data._booked_fixed_asset = value; }
        }

        public string purchase_receipt
        {
            get { return data.purchase_receipt; }
            set { data.purchase_receipt = value; }
        }

        private double _purchase_receipt_amount = 0.0;
        public double purchase_receipt_amount
        {
            get { return data._purchase_receipt_amount; }
            set { data._purchase_receipt_amount = value; }
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

        private int _allow_monthly_depreciation = 0;
        public int allow_monthly_depreciation
        {
            get { return data._allow_monthly_depreciation; }
            set { data._allow_monthly_depreciation = value; }
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