using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hub_tracked_item
{
    public class ERPHub_tracked_item : ERPNextObjectBase
    {
        public ERPHub_tracked_item() : this(new ERPObject(DocType.Hub_tracked_item)) { }
        public ERPHub_tracked_item(ERPObject obj) : base(obj) { }

        public static ERPHub_tracked_item Create(string itemcode, string hubcategory, int published, string imagelist)

        {
            ERPHub_tracked_item obj = new ERPHub_tracked_item();
            obj.item_code = itemcode;
            obj.hub_category = hubcategory;
            obj.published = published;
            obj.image_list = imagelist;
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

        public string hub_category
        {
            get { return data.hub_category; }
            set { data.hub_category = value; }
        }

        private int _published = 0;
        public int published
        {
            get { return data._published; }
            set { data._published = value; }
        }

        public string image_list
        {
            get { return data.image_list; }
            set { data.image_list = value; }
        }


    }

    //Enums go here

}