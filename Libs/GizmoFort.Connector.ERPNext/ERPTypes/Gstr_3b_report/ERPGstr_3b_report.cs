using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Gstr_3b_report
{
    public class ERPGstr_3b_report : ERPNextObjectBase
    {
        public ERPGstr_3b_report() : this(new ERPObject(DocType.Gstr_3b_report)) { }
        public ERPGstr_3b_report(ERPObject obj) : base(obj) { }

        public static ERPGstr_3b_report Create()

        {
            ERPGstr_3b_report obj = new ERPGstr_3b_report();
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public string company_address
        {
            get { return data.company_address; }
            set { data.company_address = value; }
        }

        public string year
        {
            get { return data.year; }
            set { data.year = value; }
        }

        public Month month
        {
            get { return parseEnum<Month>(data.month); }
            set { data.month = value.ToString(); }
        }

        public string json_output
        {
            get { return data.json_output; }
            set { data.json_output = value; }
        }

        public string missing_field_invoices
        {
            get { return data.missing_field_invoices; }
            set { data.missing_field_invoices = value; }
        }


    }

    //Enums go here
    public enum Month
    {
        [Description("January")]
        January,
        [Description("February")]
        February,
        [Description("March")]
        March,
        [Description("April")]
        April,
        [Description("May")]
        May,
        [Description("June")]
        June,
        [Description("July")]
        July,
        [Description("August")]
        August,
        [Description("September")]
        September,
        [Description("October")]
        October,
        [Description("November")]
        November,
        [Description("December")]
        December,
    }


}