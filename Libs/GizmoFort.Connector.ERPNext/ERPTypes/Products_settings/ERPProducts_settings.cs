using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Products_settings
{
    public class ERPProducts_settings : ERPNextObjectBase
    {
        public ERPProducts_settings() : this(new ERPObject(DocType.Products_settings)) { }
        public ERPProducts_settings(ERPObject obj) : base(obj) { }

        public static ERPProducts_settings Create(int homepageisproducts, int showavailabilitystatus, int productsperpage, int enablefieldfilters, string filterfields, int enableattributefilters, string filterattributes, int hidevariants)

        {
            ERPProducts_settings obj = new ERPProducts_settings();
            obj.home_page_is_products = homepageisproducts;
            obj.show_availability_status = showavailabilitystatus;
            obj.products_per_page = productsperpage;
            obj.enable_field_filters = enablefieldfilters;
            obj.filter_fields = filterfields;
            obj.enable_attribute_filters = enableattributefilters;
            obj.filter_attributes = filterattributes;
            obj.hide_variants = hidevariants;
            return obj;
        }

        private int _home_page_is_products = 0;
        public int home_page_is_products
        {
            get { return data._home_page_is_products; }
            set { data._home_page_is_products = value; }
        }

        private int _show_availability_status = 0;
        public int show_availability_status
        {
            get { return data._show_availability_status; }
            set { data._show_availability_status = value; }
        }

        private int _products_per_page = 0;
        public int products_per_page
        {
            get { return data._products_per_page; }
            set { data._products_per_page = value; }
        }

        private int _enable_field_filters = 0;
        public int enable_field_filters
        {
            get { return data._enable_field_filters; }
            set { data._enable_field_filters = value; }
        }

        public string filter_fields
        {
            get { return data.filter_fields; }
            set { data.filter_fields = value; }
        }

        private int _enable_attribute_filters = 0;
        public int enable_attribute_filters
        {
            get { return data._enable_attribute_filters; }
            set { data._enable_attribute_filters = value; }
        }

        public string filter_attributes
        {
            get { return data.filter_attributes; }
            set { data.filter_attributes = value; }
        }

        private int _hide_variants = 0;
        public int hide_variants
        {
            get { return data._hide_variants; }
            set { data._hide_variants = value; }
        }


    }

    //Enums go here

}