using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_settings
{
    public class ERPStock_settings : ERPNextObjectBase
    {
        public ERPStock_settings() : this(new ERPObject(DocType.Stock_settings)) { }
        public ERPStock_settings(ERPObject obj) : base(obj) { }

        public static ERPStock_settings Create()

        {
            ERPStock_settings obj = new ERPStock_settings();
            return obj;
        }

        public Itemnamingby item_naming_by
        {
            get { return parseEnum<Itemnamingby>(data.item_naming_by); }
            set { data.item_naming_by = value.ToString(); }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public string default_warehouse
        {
            get { return data.default_warehouse; }
            set { data.default_warehouse = value; }
        }

        public string sample_retention_warehouse
        {
            get { return data.sample_retention_warehouse; }
            set { data.sample_retention_warehouse = value; }
        }

        public Valuationmethod valuation_method
        {
            get { return parseEnum<Valuationmethod>(data.valuation_method); }
            set { data.valuation_method = value.ToString(); }
        }

        public double over_delivery_receipt_allowance
        {
            get { return data.over_delivery_receipt_allowance; }
            set { data.over_delivery_receipt_allowance = value; }
        }

        public Actionifqualityinspectionisnotsubmitted action_if_quality_inspection_is_not_submitted
        {
            get { return parseEnum<Actionifqualityinspectionisnotsubmitted>(data.action_if_quality_inspection_is_not_submitted); }
            set { data.action_if_quality_inspection_is_not_submitted = value.ToString(); }
        }

        public long show_barcode_field
        {
            get { return data.show_barcode_field; }
            set { data.show_barcode_field = value; }
        }

        public long clean_description_html
        {
            get { return data.clean_description_html; }
            set { data.clean_description_html = value; }
        }

        public long auto_insert_price_list_rate_if_missing
        {
            get { return data.auto_insert_price_list_rate_if_missing; }
            set { data.auto_insert_price_list_rate_if_missing = value; }
        }

        public long allow_negative_stock
        {
            get { return data.allow_negative_stock; }
            set { data.allow_negative_stock = value; }
        }

        public long automatically_set_serial_nos_based_on_fifo
        {
            get { return data.automatically_set_serial_nos_based_on_fifo; }
            set { data.automatically_set_serial_nos_based_on_fifo = value; }
        }

        public long seta_qty_in_transactions_based_on_serial_no_input
        {
            get { return data.seta_qty_in_transactions_based_on_serial_no_input; }
            set { data.seta_qty_in_transactions_based_on_serial_no_input = value; }
        }

        public long auto_indent
        {
            get { return data.auto_indent; }
            set { data.auto_indent = value; }
        }

        public long reorder_email_notify
        {
            get { return data.reorder_email_notify; }
            set { data.reorder_email_notify = value; }
        }

        public string stock_frozen_upto
        {
            get { return data.stock_frozen_upto; }
            set { data.stock_frozen_upto = value; }
        }

        public int stock_frozen_upto_days
        {
            get { return data.stock_frozen_upto_days; }
            set { data.stock_frozen_upto_days = value; }
        }

        public string stock_auth_role
        {
            get { return data.stock_auth_role; }
            set { data.stock_auth_role = value; }
        }

        public long use_naming_series
        {
            get { return data.use_naming_series; }
            set { data.use_naming_series = value; }
        }

        public string naming_series_prefix
        {
            get { return data.naming_series_prefix; }
            set { data.naming_series_prefix = value; }
        }

        public long allow_from_dn
        {
            get { return data.allow_from_dn; }
            set { data.allow_from_dn = value; }
        }

        public long allow_from_pr
        {
            get { return data.allow_from_pr; }
            set { data.allow_from_pr = value; }
        }


    }

    //Enums go here
    public enum Itemnamingby
    {
        [Description("Item Code")]
        ItemCode,
        [Description("Naming Series")]
        NamingSeries,
    }

    public enum Valuationmethod
    {
        [Description("FIFO")]
        FIFO,
        [Description("Moving Average")]
        MovingAverage,
    }

    public enum Actionifqualityinspectionisnotsubmitted
    {
        [Description("Stop")]
        Stop,
        [Description("Warn")]
        Warn,
    }


}