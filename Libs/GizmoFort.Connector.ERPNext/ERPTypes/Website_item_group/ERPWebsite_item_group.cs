using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Website_item_group
{
    public class ERPWebsite_item_group : ERPNextObjectBase
    {
        public ERPWebsite_item_group() : this(new ERPObject(DocType.Website_item_group)) { }
        public ERPWebsite_item_group(ERPObject obj) : base(obj) { }

        public static ERPWebsite_item_group Create(string itemgroup)

        {
            ERPWebsite_item_group obj = new ERPWebsite_item_group();
            obj.item_group = itemgroup;
            return obj;
        }

        public string item_group
        {
            get { return data.item_group; }
            set
            {
                data.item_group = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}