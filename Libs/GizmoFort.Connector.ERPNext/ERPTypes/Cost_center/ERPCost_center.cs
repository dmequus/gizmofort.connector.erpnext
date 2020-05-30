using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cost_center
{
    public class ERPCost_center : ERPNextObjectBase
    {
        public ERPCost_center() : this(new ERPObject(DocType.Cost_center)) { }
        public ERPCost_center(ERPObject obj) : base(obj) { }

        public static ERPCost_center Create(string costcentername, string parentcostcenter, string company)

        {
            ERPCost_center obj = new ERPCost_center();
            obj.cost_center_name = costcentername;
            obj.parent_cost_center = parentcostcenter;
            obj.company = company;
            return obj;
        }

        public string cost_center_name
        {
            get { return data.cost_center_name; }
            set
            {
                data.cost_center_name = value;
                data.name = value;
            }

        }

        public string parent_cost_center
        {
            get { return data.parent_cost_center; }
            set { data.parent_cost_center = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string cost_center_number
        {
            get { return data.cost_center_number; }
            set { data.cost_center_number = value; }
        }

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
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

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }


    }

    //Enums go here

}