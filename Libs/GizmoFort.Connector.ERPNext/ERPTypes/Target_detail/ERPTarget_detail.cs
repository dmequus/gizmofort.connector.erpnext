using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Target_detail
{
    public class ERPTarget_detail : ERPNextObjectBase
    {
        public ERPTarget_detail() : this(new ERPObject(DocType.Target_detail)) { }
        public ERPTarget_detail(ERPObject obj) : base(obj) { }

        public static ERPTarget_detail Create(string itemgroup, string fiscalyear, double targetqty, double targetamount, string distributionid)

        {
            ERPTarget_detail obj = new ERPTarget_detail();
            obj.item_group = itemgroup;
            obj.fiscal_year = fiscalyear;
            obj.target_qty = targetqty;
            obj.target_amount = targetamount;
            obj.distribution_id = distributionid;
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

        public string fiscal_year
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        public double target_qty
        {
            get { return data.target_qty; }
            set { data.target_qty = value; }
        }

        public double target_amount
        {
            get { return data.target_amount; }
            set { data.target_amount = value; }
        }

        public string distribution_id
        {
            get { return data.distribution_id; }
            set { data.distribution_id = value; }
        }


    }

    //Enums go here

}