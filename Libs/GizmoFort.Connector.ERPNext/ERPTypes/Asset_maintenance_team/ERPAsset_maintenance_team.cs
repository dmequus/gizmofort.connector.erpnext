using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance_team
{
    public class ERPAsset_maintenance_team : ERPNextObjectBase
    {
        public ERPAsset_maintenance_team() : this(new ERPObject(DocType.Asset_maintenance_team)) { }
        public ERPAsset_maintenance_team(ERPObject obj) : base(obj) { }

        public static ERPAsset_maintenance_team Create(string maintenanceteamname, string maintenancemanager, string maintenancemanagername, string company, string maintenanceteammembers)

        {
            ERPAsset_maintenance_team obj = new ERPAsset_maintenance_team();
            obj.maintenance_team_name = maintenanceteamname;
            obj.maintenance_manager = maintenancemanager;
            obj.maintenance_manager_name = maintenancemanagername;
            obj.company = company;
            obj.maintenance_team_members = maintenanceteammembers;
            return obj;
        }

        public string maintenance_team_name
        {
            get { return data.maintenance_team_name; }
            set
            {
                data.maintenance_team_name = value;
                data.name = value;
            }

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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string maintenance_team_members
        {
            get { return data.maintenance_team_members; }
            set { data.maintenance_team_members = value; }
        }


    }

    //Enums go here

}