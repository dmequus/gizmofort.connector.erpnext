using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_item_group
{
    public class ERPPos_item_group : ERPNextObjectBase
    {
        public ERPPos_item_group() : this(new ERPObject(DocType.Pos_item_group)) { }
        public ERPPos_item_group(ERPObject obj) : base(obj) { }

        public static ERPPos_item_group Create(string itemgroup)

        {
            ERPPos_item_group obj = new ERPPos_item_group();
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