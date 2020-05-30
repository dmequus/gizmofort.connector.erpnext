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

        private double _over_delivery_receipt_allowance = 0.0;
        public double over_delivery_receipt_allowance
        {
            get { return data._over_delivery_receipt_allowance; }
            set { data._over_delivery_receipt_allowance = value; }
        }

        public Actionifqualityinspectionisnotsubmitted action_if_quality_inspection_is_not_submitted
        {
            get { return parseEnum<Actionifqualityinspectionisnotsubmitted>(data.action_if_quality_inspection_is_not_submitted); }
            set { data.action_if_quality_inspection_is_not_submitted = value.ToString(); }
        }

        private int _show_barcode_field = 0;
        public int show_barcode_field
        {
            get { return data._show_barcode_field; }
            set { data._show_barcode_field = value; }
        }

        private int _clean_description_html = 0;
        public int clean_description_html
        {
            get { return data._clean_description_html; }
            set { data._clean_description_html = value; }
        }

        private int _auto_insert_price_list_rate_if_missing = 0;
        public int auto_insert_price_list_rate_if_missing
        {
            get { return data._auto_insert_price_list_rate_if_missing; }
            set { data._auto_insert_price_list_rate_if_missing = value; }
        }

        private int _allow_negative_stock = 0;
        public int allow_negative_stock
        {
            get { return data._allow_negative_stock; }
            set { data._allow_negative_stock = value; }
        }

        private int _automatically_set_serial_nos_based_on_fifo = 0;
        public int automatically_set_serial_nos_based_on_fifo
        {
            get { return data._automatically_set_serial_nos_based_on_fifo; }
            set { data._automatically_set_serial_nos_based_on_fifo = value; }
        }

        private int _seta_qty_in_transactions_based_on_serial_no_input = 0;
        public int seta_qty_in_transactions_based_on_serial_no_input
        {
            get { return data._seta_qty_in_transactions_based_on_serial_no_input; }
            set { data._seta_qty_in_transactions_based_on_serial_no_input = value; }
        }

        private int _auto_indent = 0;
        public int auto_indent
        {
            get { return data._auto_indent; }
            set { data._auto_indent = value; }
        }

        private int _reorder_email_notify = 0;
        public int reorder_email_notify
        {
            get { return data._reorder_email_notify; }
            set { data._reorder_email_notify = value; }
        }

        public string stock_frozen_upto
        {
            get { return data.stock_frozen_upto; }
            set { data.stock_frozen_upto = value; }
        }

        private int _stock_frozen_upto_days = 0;
        public int stock_frozen_upto_days
        {
            get { return data._stock_frozen_upto_days; }
            set { data._stock_frozen_upto_days = value; }
        }

        public string stock_auth_role
        {
            get { return data.stock_auth_role; }
            set { data.stock_auth_role = value; }
        }

        private int _use_naming_series = 0;
        public int use_naming_series
        {
            get { return data._use_naming_series; }
            set { data._use_naming_series = value; }
        }

        public string naming_series_prefix
        {
            get { return data.naming_series_prefix; }
            set { data.naming_series_prefix = value; }
        }

        private int _allow_from_dn = 0;
        public int allow_from_dn
        {
            get { return data._allow_from_dn; }
            set { data._allow_from_dn = value; }
        }

        private int _allow_from_pr = 0;
        public int allow_from_pr
        {
            get { return data._allow_from_pr; }
            set { data._allow_from_pr = value; }
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