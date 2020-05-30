using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance
{
    public class ERPAsset_maintenance : ERPNextObjectBase
    {
        public ERPAsset_maintenance() : this(new ERPObject(DocType.Asset_maintenance)) { }
        public ERPAsset_maintenance(ERPObject obj) : base(obj) { }

        public static ERPAsset_maintenance Create(string assetname, string assetcategory, string itemcode, string itemname, string company, string selectserialno, string serialno, string maintenanceteam, string maintenancemanager, string maintenancemanagername, string assetmaintenancetasks)

        {
            ERPAsset_maintenance obj = new ERPAsset_maintenance();
            obj.asset_name = assetname;
            obj.asset_category = assetcategory;
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.company = company;
            obj.select_serial_no = selectserialno;
            obj.serial_no = serialno;
            obj.maintenance_team = maintenanceteam;
            obj.maintenance_manager = maintenancemanager;
            obj.maintenance_manager_name = maintenancemanagername;
            obj.asset_maintenance_tasks = assetmaintenancetasks;
            return obj;
        }

        public string asset_name
        {
            get { return data.asset_name; }
            set
            {
                data.asset_name = value;
                data.name = value;
            }

        }

        public string asset_category
        {
            get { return data.asset_category; }
            set { data.asset_category = value; }
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string select_serial_no
        {
            get { return data.select_serial_no; }
            set { data.select_serial_no = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        public string maintenance_team
        {
            get { return data.maintenance_team; }
            set { data.maintenance_team = value; }
        }

        public string maintenance_manager
        {
            get { return data.maintenance_manager; }
            set { data.maintenance_manager = value; }
        }

        public string maintenance_manager_name
        {
            get { return data.maintenance_manager_name; }
            set { data.maintenance_manager_name = value; }
        }

        public string asset_maintenance_tasks
        {
            get { return data.asset_maintenance_tasks; }
            set { data.asset_maintenance_tasks = value; }
        }


    }

    //Enums go here

}