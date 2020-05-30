using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_group
{
    public class ERPItem_group : ERPNextObjectBase
    {
        public ERPItem_group() : this(new ERPObject(DocType.Item_group)) { }
        public ERPItem_group(ERPObject obj) : base(obj) { }

        public static ERPItem_group Create(string itemgroupname)

        {
            ERPItem_group obj = new ERPItem_group();
            obj.item_group_name = itemgroupname;
            return obj;
        }

        public string item_group_name
        {
            get { return data.item_group_name; }
            set
            {
                data.item_group_name = value;
                data.name = value;
            }

        }

        public string parent_item_group
        {
            get { return data.parent_item_group; }
            set { data.parent_item_group = value; }
        }

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string item_group_defaults
        {
            get { return data.item_group_defaults; }
            set { data.item_group_defaults = value; }
        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }

        private int _show_in_website = 0;
        public int show_in_website
        {
            get { return data._show_in_website; }
            set { data._show_in_website = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        private int _weightage = 0;
        public int weightage
        {
            get { return data._weightage; }
            set { data._weightage = value; }
        }

        public string slideshow
        {
            get { return data.slideshow; }
            set { data.slideshow = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string website_specifications
        {
            get { return data.website_specifications; }
            set { data.website_specifications = value; }
        }

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }


    }

    //Enums go here

}