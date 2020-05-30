using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Brand
{
    public class ERPBrand : ERPNextObjectBase
    {
        public ERPBrand() : this(new ERPObject(DocType.Brand)) { }
        public ERPBrand(ERPObject obj) : base(obj) { }

        public static ERPBrand Create(string brand, string description, string branddefaults)

        {
            ERPBrand obj = new ERPBrand();
            obj.brand = brand;
            obj.description = description;
            obj.brand_defaults = branddefaults;
            return obj;
        }

        public string brand
        {
            get { return data.brand; }
            set
            {
                data.brand = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string brand_defaults
        {
            get { return data.brand_defaults; }
            set { data.brand_defaults = value; }
        }


    }

    //Enums go here

}