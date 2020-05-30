using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_movement_item
{
    public class ERPAsset_movement_item : ERPNextObjectBase
    {
        public ERPAsset_movement_item() : this(new ERPObject(DocType.Asset_movement_item)) { }
        public ERPAsset_movement_item(ERPObject obj) : base(obj) { }

        public static ERPAsset_movement_item Create(string asset)

        {
            ERPAsset_movement_item obj = new ERPAsset_movement_item();
            obj.asset = asset;
            return obj;
        }

        public string asset
        {
            get { return data.asset; }
            set
            {
                data.asset = value;
                data.name = value;
            }

        }

        public string asset_name
        {
            get { return data.asset_name; }
            set { data.asset_name = value; }
        }

        public string source_location
        {
            get { return data.source_location; }
            set { data.source_location = value; }
        }

        public string target_location
        {
            get { return data.target_location; }
            set { data.target_location = value; }
        }

        public string from_employee
        {
            get { return data.from_employee; }
            set { data.from_employee = value; }
        }

        public string to_employee
        {
            get { return data.to_employee; }
            set { data.to_employee = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }


    }

    //Enums go here

}