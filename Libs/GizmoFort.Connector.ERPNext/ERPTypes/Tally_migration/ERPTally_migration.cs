using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Tally_migration
{
    public class ERPTally_migration : ERPNextObjectBase
    {
        public ERPTally_migration() : this(new ERPObject(DocType.Tally_migration)) { }
        public ERPTally_migration(ERPObject obj) : base(obj) { }

        public static ERPTally_migration Create(string tallycreditorsaccount, string tallydebtorsaccount)

        {
            ERPTally_migration obj = new ERPTally_migration();
            obj.tally_creditors_account = tallycreditorsaccount;
            obj.tally_debtors_account = tallydebtorsaccount;
            return obj;
        }

        public string tally_creditors_account
        {
            get { return data.tally_creditors_account; }
            set
            {
                data.tally_creditors_account = value;
                data.name = value;
            }

        }

        public string tally_debtors_account
        {
            get { return data.tally_debtors_account; }
            set { data.tally_debtors_account = value; }
        }

        public string status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        public string master_data
        {
            get { return data.master_data; }
            set { data.master_data = value; }
        }

        public string tally_company
        {
            get { return data.tally_company; }
            set { data.tally_company = value; }
        }

        public string erpnext_company
        {
            get { return data.erpnext_company; }
            set { data.erpnext_company = value; }
        }

        public string chart_of_accounts
        {
            get { return data.chart_of_accounts; }
            set { data.chart_of_accounts = value; }
        }

        public string parties
        {
            get { return data.parties; }
            set { data.parties = value; }
        }

        public string addresses
        {
            get { return data.addresses; }
            set { data.addresses = value; }
        }

        public string uoms
        {
            get { return data.uoms; }
            set { data.uoms = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string vouchers
        {
            get { return data.vouchers; }
            set { data.vouchers = value; }
        }

        public string default_warehouse
        {
            get { return data.default_warehouse; }
            set { data.default_warehouse = value; }
        }

        public string round_off_account
        {
            get { return data.round_off_account; }
            set { data.round_off_account = value; }
        }

        public string default_cost_center
        {
            get { return data.default_cost_center; }
            set { data.default_cost_center = value; }
        }

        public long is_master_data_processed
        {
            get { return data.is_master_data_processed; }
            set { data.is_master_data_processed = value; }
        }

        public long is_day_book_data_processed
        {
            get { return data.is_day_book_data_processed; }
            set { data.is_day_book_data_processed = value; }
        }

        public long is_day_book_data_imported
        {
            get { return data.is_day_book_data_imported; }
            set { data.is_day_book_data_imported = value; }
        }

        public long is_master_data_imported
        {
            get { return data.is_master_data_imported; }
            set { data.is_master_data_imported = value; }
        }

        public string day_book_data
        {
            get { return data.day_book_data; }
            set { data.day_book_data = value; }
        }

        public string default_uom
        {
            get { return data.default_uom; }
            set { data.default_uom = value; }
        }


    }

    //Enums go here

}