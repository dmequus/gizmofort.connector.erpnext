using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Products_settings
{
    public class ERPProducts_settings : ERPNextObjectBase
    {
        public ERPProducts_settings() : this(new ERPObject(DocType.Products_settings)) { }
        public ERPProducts_settings(ERPObject obj) : base(obj) { }

        public static ERPProducts_settings Create(long homepageisproducts, long showavailabilitystatus, int productsperpage, long enablefieldfilters, string filterfields, long enableattributefilters, string filterattributes, long hidevariants)

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

        public long home_page_is_products
        {
            get { return data.home_page_is_products; }
            set { data.home_page_is_products = value; }
        }

        public long show_availability_status
        {
            get { return data.show_availability_status; }
            set { data.show_availability_status = value; }
        }

        public int products_per_page
        {
            get { return data.products_per_page; }
            set { data.products_per_page = value; }
        }

        public long enable_field_filters
        {
            get { return data.enable_field_filters; }
            set { data.enable_field_filters = value; }
        }

        public string filter_fields
        {
            get { return data.filter_fields; }
            set { data.filter_fields = value; }
        }

        public long enable_attribute_filters
        {
            get { return data.enable_attribute_filters; }
            set { data.enable_attribute_filters = value; }
        }

        public string filter_attributes
        {
            get { return data.filter_attributes; }
            set { data.filter_attributes = value; }
        }

        public long hide_variants
        {
            get { return data.hide_variants; }
            set { data.hide_variants = value; }
        }


    }

    //Enums go here

}