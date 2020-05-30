using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Territory
{
    public class ERPTerritory : ERPNextObjectBase
    {
        public ERPTerritory() : this(new ERPObject(DocType.Territory)) { }
        public ERPTerritory(ERPObject obj) : base(obj) { }

        public static ERPTerritory Create(string territoryname)

        {
            ERPTerritory obj = new ERPTerritory();
            obj.territory_name = territoryname;
            return obj;
        }

        public string territory_name
        {
            get { return data.territory_name; }
            set
            {
                data.territory_name = value;
                data.name = value;
            }

        }

        public string parent_territory
        {
            get { return data.parent_territory; }
            set { data.parent_territory = value; }
        }

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        public string territory_manager
        {
            get { return data.territory_manager; }
            set { data.territory_manager = value; }
        }

        public int lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        public int rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        public string targets
        {
            get { return data.targets; }
            set { data.targets = value; }
        }


    }

    //Enums go here

}