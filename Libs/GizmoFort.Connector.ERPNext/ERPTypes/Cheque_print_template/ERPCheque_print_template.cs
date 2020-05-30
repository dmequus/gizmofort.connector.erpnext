using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cheque_print_template
{
    public class ERPCheque_print_template : ERPNextObjectBase
    {
        public ERPCheque_print_template() : this(new ERPObject(DocType.Cheque_print_template)) { }
        public ERPCheque_print_template(ERPObject obj) : base(obj) { }

        public static ERPCheque_print_template Create(Settings settings, long hasprintformat, string bankname, Chequesize chequesize, double startingpositionfromtopedge, double chequewidth, double chequeheight, string scannedcheque, long isaccountpayable, double accpaydistfromtopedge, double accpaydistfromleftedge, string messagetoshow, string datesettings, double datedistfromtopedge, double datedistfromleftedge, double payernamefromtopedge, double payernamefromleftedge, string html19, double amtinwordsfromtopedge, double amtinwordsfromleftedge, double amtinwordwidth, double amtinwordslinespacing, double amtinfiguresfromtopedge, double amtinfiguresfromleftedge, string accountnosettings, double accnodistfromtopedge, double accnodistfromleftedge, double signatoryfromtopedge, double signatoryfromleftedge, string chequeprintpreview)

        {
            ERPCheque_print_template obj = new ERPCheque_print_template();
            obj.settings = settings;
            obj.has_print_format = hasprintformat;
            obj.bank_name = bankname;
            obj.cheque_size = chequesize;
            obj.starting_position_from_top_edge = startingpositionfromtopedge;
            obj.cheque_width = chequewidth;
            obj.cheque_height = chequeheight;
            obj.scanned_cheque = scannedcheque;
            obj.is_account_payable = isaccountpayable;
            obj.acc_pay_dist_from_top_edge = accpaydistfromtopedge;
            obj.acc_pay_dist_from_left_edge = accpaydistfromleftedge;
            obj.message_to_show = messagetoshow;
            obj.date_settings = datesettings;
            obj.date_dist_from_top_edge = datedistfromtopedge;
            obj.date_dist_from_left_edge = datedistfromleftedge;
            obj.payer_name_from_top_edge = payernamefromtopedge;
            obj.payer_name_from_left_edge = payernamefromleftedge;
            obj.html_19 = html19;
            obj.amt_in_words_from_top_edge = amtinwordsfromtopedge;
            obj.amt_in_words_from_left_edge = amtinwordsfromleftedge;
            obj.amt_in_word_width = amtinwordwidth;
            obj.amt_in_words_line_spacing = amtinwordslinespacing;
            obj.amt_in_figures_from_top_edge = amtinfiguresfromtopedge;
            obj.amt_in_figures_from_left_edge = amtinfiguresfromleftedge;
            obj.account_no_settings = accountnosettings;
            obj.acc_no_dist_from_top_edge = accnodistfromtopedge;
            obj.acc_no_dist_from_left_edge = accnodistfromleftedge;
            obj.signatory_from_top_edge = signatoryfromtopedge;
            obj.signatory_from_left_edge = signatoryfromleftedge;
            obj.cheque_print_preview = chequeprintpreview;
            return obj;
        }

        public Settings settings
        {
            get { return parseEnum<Settings>(data.settings); }
            set { data.settings = value.ToString(); }
        }

        public long has_print_format
        {
            get { return data.has_print_format; }
            set { data.has_print_format = value; }
        }

        public string bank_name
        {
            get { return data.bank_name; }
            set { data.bank_name = value; }
        }

        public Chequesize cheque_size
        {
            get { return parseEnum<Chequesize>(data.cheque_size); }
            set { data.cheque_size = value.ToString(); }
        }

        public double starting_position_from_top_edge
        {
            get { return data.starting_position_from_top_edge; }
            set { data.starting_position_from_top_edge = value; }
        }

        public double cheque_width
        {
            get { return data.cheque_width; }
            set { data.cheque_width = value; }
        }

        public double cheque_height
        {
            get { return data.cheque_height; }
            set { data.cheque_height = value; }
        }

        public string scanned_cheque
        {
            get { return data.scanned_cheque; }
            set { data.scanned_cheque = value; }
        }

        public long is_account_payable
        {
            get { return data.is_account_payable; }
            set { data.is_account_payable = value; }
        }

        public double acc_pay_dist_from_top_edge
        {
            get { return data.acc_pay_dist_from_top_edge; }
            set { data.acc_pay_dist_from_top_edge = value; }
        }

        public double acc_pay_dist_from_left_edge
        {
            get { return data.acc_pay_dist_from_left_edge; }
            set { data.acc_pay_dist_from_left_edge = value; }
        }

        public string message_to_show
        {
            get { return data.message_to_show; }
            set { data.message_to_show = value; }
        }

        public string date_settings
        {
            get { return data.date_settings; }
            set { data.date_settings = value; }
        }

        public double date_dist_from_top_edge
        {
            get { return data.date_dist_from_top_edge; }
            set { data.date_dist_from_top_edge = value; }
        }

        public double date_dist_from_left_edge
        {
            get { return data.date_dist_from_left_edge; }
            set { data.date_dist_from_left_edge = value; }
        }

        public double payer_name_from_top_edge
        {
            get { return data.payer_name_from_top_edge; }
            set { data.payer_name_from_top_edge = value; }
        }

        public double payer_name_from_left_edge
        {
            get { return data.payer_name_from_left_edge; }
            set { data.payer_name_from_left_edge = value; }
        }

        public string html_19
        {
            get { return data.html_19; }
            set { data.html_19 = value; }
        }

        public double amt_in_words_from_top_edge
        {
            get { return data.amt_in_words_from_top_edge; }
            set { data.amt_in_words_from_top_edge = value; }
        }

        public double amt_in_words_from_left_edge
        {
            get { return data.amt_in_words_from_left_edge; }
            set { data.amt_in_words_from_left_edge = value; }
        }

        public double amt_in_word_width
        {
            get { return data.amt_in_word_width; }
            set { data.amt_in_word_width = value; }
        }

        public double amt_in_words_line_spacing
        {
            get { return data.amt_in_words_line_spacing; }
            set { data.amt_in_words_line_spacing = value; }
        }

        public double amt_in_figures_from_top_edge
        {
            get { return data.amt_in_figures_from_top_edge; }
            set { data.amt_in_figures_from_top_edge = value; }
        }

        public double amt_in_figures_from_left_edge
        {
            get { return data.amt_in_figures_from_left_edge; }
            set { data.amt_in_figures_from_left_edge = value; }
        }

        public string account_no_settings
        {
            get { return data.account_no_settings; }
            set { data.account_no_settings = value; }
        }

        public double acc_no_dist_from_top_edge
        {
            get { return data.acc_no_dist_from_top_edge; }
            set { data.acc_no_dist_from_top_edge = value; }
        }

        public double acc_no_dist_from_left_edge
        {
            get { return data.acc_no_dist_from_left_edge; }
            set { data.acc_no_dist_from_left_edge = value; }
        }

        public double signatory_from_top_edge
        {
            get { return data.signatory_from_top_edge; }
            set { data.signatory_from_top_edge = value; }
        }

        public double signatory_from_left_edge
        {
            get { return data.signatory_from_left_edge; }
            set { data.signatory_from_left_edge = value; }
        }

        public string cheque_print_preview
        {
            get { return data.cheque_print_preview; }
            set { data.cheque_print_preview = value; }
        }


    }

    //Enums go here
    public enum Settings
    {
        [Description("<div>")]
        div,
        [Description("<h3> All dimensions in centimeter only </h3>")]
        Alldimensionsincentimeteronly,
        [Description("</div>")]
        closediv,
    }

    public enum Chequesize
    {
        [Description("Regular")]
        Regular,
        [Description("A4")]
        A,
    }


}