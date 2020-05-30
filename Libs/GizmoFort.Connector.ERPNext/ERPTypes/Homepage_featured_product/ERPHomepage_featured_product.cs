using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Homepage_featured_product
{
    public class ERPHomepage_featured_product : ERPNextObjectBase
    {
        public ERPHomepage_featured_product() : this(new ERPObject(DocType.Homepage_featured_product)) { }
        public ERPHomepage_featured_product(ERPObject obj) : base(obj) { }

        public static ERPHomepage_featured_product Create(string itemcode, string itemname, string description, string image, string thumbnail, string route)

        {
            ERPHomepage_featured_product obj = new ERPHomepage_featured_product();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.description = description;
            obj.image = image;
            obj.thumbnail = thumbnail;
            obj.route = route;
            return obj;
        }

        public string item_code
        {
            get { return data.item_code; }
            set
            {
                data.item_code = value;
                data.name = value;
            }

        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string thumbnail
        {
            get { return data.thumbnail; }
            set { data.thumbnail = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }


    }

    //Enums go here

}