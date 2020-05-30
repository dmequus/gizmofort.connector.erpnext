using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Price_list
{
    public class ERPPrice_list : ERPNextObjectBase
    {
        public ERPPrice_list() : this(new ERPObject(DocType.Price_list)) { }
        public ERPPrice_list(ERPObject obj) : base(obj) { }

        public static ERPPrice_list Create(int enabled, string pricelistname, string currency, int buying, int selling, int pricenotuomdependent, string countries)

        {
            ERPPrice_list obj = new ERPPrice_list();
            obj.enabled = enabled;
            obj.price_list_name = pricelistname;
            obj.currency = currency;
            obj.buying = buying;
            obj.selling = selling;
            obj.price_not_uom_dependent = pricenotuomdependent;
            obj.countries = countries;
            return obj;
        }

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
        }

        public string price_list_name
        {
            get { return data.price_list_name; }
            set { data.price_list_name = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        private int _buying = 0;
        public int buying
        {
            get { return data._buying; }
            set { data._buying = value; }
        }

        private int _selling = 0;
        public int selling
        {
            get { return data._selling; }
            set { data._selling = value; }
        }

        private int _price_not_uom_dependent = 0;
        public int price_not_uom_dependent
        {
            get { return data._price_not_uom_dependent; }
            set { data._price_not_uom_dependent = value; }
        }

        public string countries
        {
            get { return data.countries; }
            set { data.countries = value; }
        }


    }

    //Enums go here

}