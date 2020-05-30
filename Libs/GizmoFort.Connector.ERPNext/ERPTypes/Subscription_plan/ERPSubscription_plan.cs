using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription_plan
{
    public class ERPSubscription_plan : ERPNextObjectBase
    {
        public ERPSubscription_plan() : this(new ERPObject(DocType.Subscription_plan)) { }
        public ERPSubscription_plan(ERPObject obj) : base(obj) { }

        public static ERPSubscription_plan Create(string planname, string item, Pricedetermination pricedetermination, Billinginterval billinginterval, int billingintervalcount)

        {
            ERPSubscription_plan obj = new ERPSubscription_plan();
            obj.plan_name = planname;
            obj.item = item;
            obj.price_determination = pricedetermination;
            obj.billing_interval = billinginterval;
            obj.billing_interval_count = billingintervalcount;
            return obj;
        }

        public string plan_name
        {
            get { return data.plan_name; }
            set
            {
                data.plan_name = value;
                data.name = value;
            }

        }

        public string item
        {
            get { return data.item; }
            set { data.item = value; }
        }

        public Pricedetermination price_determination
        {
            get { return parseEnum<Pricedetermination>(data.price_determination); }
            set { data.price_determination = value.ToString(); }
        }

        public Billinginterval billing_interval
        {
            get { return parseEnum<Billinginterval>(data.billing_interval); }
            set { data.billing_interval = value.ToString(); }
        }

        public int billing_interval_count
        {
            get { return data.billing_interval_count; }
            set { data.billing_interval_count = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public double cost
        {
            get { return data.cost; }
            set { data.cost = value; }
        }

        public string price_list
        {
            get { return data.price_list; }
            set { data.price_list = value; }
        }

        public string payment_plan_id
        {
            get { return data.payment_plan_id; }
            set { data.payment_plan_id = value; }
        }

        public string payment_gateway
        {
            get { return data.payment_gateway; }
            set { data.payment_gateway = value; }
        }


    }

    //Enums go here
    public enum Pricedetermination
    {
        [Description("Fixed rate")]
        Fixedrate,
        [Description("Based on price list")]
        Basedonpricelist,
    }

    public enum Billinginterval
    {
        [Description("Day")]
        Day,
        [Description("Week")]
        Week,
        [Description("Month")]
        Month,
        [Description("Year")]
        Year,
    }


}