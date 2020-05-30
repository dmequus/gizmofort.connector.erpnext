using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturer
{
    public class ERPManufacturer : ERPNextObjectBase
    {
        public ERPManufacturer() : this(new ERPObject(DocType.Manufacturer)) { }
        public ERPManufacturer(ERPObject obj) : base(obj) { }

        public static ERPManufacturer Create(string shortname)

        {
            ERPManufacturer obj = new ERPManufacturer();
            obj.short_name = shortname;
            return obj;
        }

        public string short_name
        {
            get { return data.short_name; }
            set
            {
                data.short_name = value;
                data.name = value;
            }

        }

        public string full_name
        {
            get { return data.full_name; }
            set { data.full_name = value; }
        }

        public string website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        public string country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        public string logo
        {
            get { return data.logo; }
            set { data.logo = value; }
        }

        public string notes
        {
            get { return data.notes; }
            set { data.notes = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }


    }

    //Enums go here

}