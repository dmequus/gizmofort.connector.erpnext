using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_team_member
{
    public class ERPMaintenance_team_member : ERPNextObjectBase
    {
        public ERPMaintenance_team_member() : this(new ERPObject(DocType.Maintenance_team_member)) { }
        public ERPMaintenance_team_member(ERPObject obj) : base(obj) { }

        public static ERPMaintenance_team_member Create(string teammember, string fullname, string maintenancerole)

        {
            ERPMaintenance_team_member obj = new ERPMaintenance_team_member();
            obj.team_member = teammember;
            obj.full_name = fullname;
            obj.maintenance_role = maintenancerole;
            return obj;
        }

        public string team_member
        {
            get { return data.team_member; }
            set
            {
                data.team_member = value;
                data.name = value;
            }

        }

        public string full_name
        {
            get { return data.full_name; }
            set { data.full_name = value; }
        }

        public string maintenance_role
        {
            get { return data.maintenance_role; }
            set { data.maintenance_role = value; }
        }


    }

    //Enums go here

}