using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Price_list
{
    public class ERPPrice_list : ERPNextObjectBase
    {
        public ERPPrice_list() : this(new ERPObject(DocType.Price_list)) { }
        public ERPPrice_list(ERPObject obj) : base(obj) { }

        public static ERPPrice_list Create(long enabled, string pricelistname, string currency, long buying, long selling, long pricenotuomdependent, string countries)

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

        public long enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
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

        public long buying
        {
            get { return data.buying; }
            set { data.buying = value; }
        }

        public long selling
        {
            get { return data.selling; }
            set { data.selling = value; }
        }

        public long price_not_uom_dependent
        {
            get { return data.price_not_uom_dependent; }
            set { data.price_not_uom_dependent = value; }
        }

        public string countries
        {
            get { return data.countries; }
            set { data.countries = value; }
        }


    }

    //Enums go here

}