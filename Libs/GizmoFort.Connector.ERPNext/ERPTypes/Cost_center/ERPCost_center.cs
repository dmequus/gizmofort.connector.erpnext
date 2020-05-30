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

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
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

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }


    }

    //Enums go here

}