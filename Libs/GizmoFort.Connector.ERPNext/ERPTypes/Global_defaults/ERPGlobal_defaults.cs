using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Global_defaults
{
    public class ERPGlobal_defaults : ERPNextObjectBase
    {
        public ERPGlobal_defaults() : this(new ERPObject(DocType.Global_defaults)) { }
        public ERPGlobal_defaults(ERPObject obj) : base(obj) { }

        public static ERPGlobal_defaults Create(string defaultcompany, string currentfiscalyear, string country, string defaultdistanceunit, string defaultcurrency, Hidecurrencysymbol hidecurrencysymbol, int disableroundedtotal, int disableinwords)

        {
            ERPGlobal_defaults obj = new ERPGlobal_defaults();
            obj.default_company = defaultcompany;
            obj.current_fiscal_year = currentfiscalyear;
            obj.country = country;
            obj.default_distance_unit = defaultdistanceunit;
            obj.default_currency = defaultcurrency;
            obj.hide_currency_symbol = hidecurrencysymbol;
            obj.disable_rounded_total = disableroundedtotal;
            obj.disable_in_words = disableinwords;
            return obj;
        }

        public string default_company
        {
            get { return data.default_company; }
            set
            {
                data.default_company = value;
                data.name = value;
            }

        }

        public string current_fiscal_year
        {
            get { return data.current_fiscal_year; }
            set { data.current_fiscal_year = value; }
        }

        public string country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        public string default_distance_unit
        {
            get { return data.default_distance_unit; }
            set { data.default_distance_unit = value; }
        }

        public string default_currency
        {
            get { return data.default_currency; }
            set { data.default_currency = value; }
        }

        public Hidecurrencysymbol hide_currency_symbol
        {
            get { return parseEnum<Hidecurrencysymbol>(data.hide_currency_symbol); }
            set { data.hide_currency_symbol = value.ToString(); }
        }

        private int _disable_rounded_total = 0;
        public int disable_rounded_total
        {
            get { return data._disable_rounded_total; }
            set { data._disable_rounded_total = value; }
        }

        private int _disable_in_words = 0;
        public int disable_in_words
        {
            get { return data._disable_in_words; }
            set { data._disable_in_words = value; }
        }


    }

    //Enums go here
    public enum Hidecurrencysymbol
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }


}