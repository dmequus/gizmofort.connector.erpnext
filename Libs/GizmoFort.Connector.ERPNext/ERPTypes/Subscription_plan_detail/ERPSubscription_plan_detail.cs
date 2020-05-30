using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription_plan_detail
{
    public class ERPSubscription_plan_detail : ERPNextObjectBase
    {
        public ERPSubscription_plan_detail() : this(new ERPObject(DocType.Subscription_plan_detail)) { }
        public ERPSubscription_plan_detail(ERPObject obj) : base(obj) { }

        public static ERPSubscription_plan_detail Create(int qty, string plan)

        {
            ERPSubscription_plan_detail obj = new ERPSubscription_plan_detail();
            obj.qty = qty;
            obj.plan = plan;
            return obj;
        }

        public int qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public string plan
        {
            get { return data.plan; }
            set { data.plan = value; }
        }


    }

    //Enums go here

}