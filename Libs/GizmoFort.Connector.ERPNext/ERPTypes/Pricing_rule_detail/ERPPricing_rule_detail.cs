using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_detail
{
    public class ERPPricing_rule_detail : ERPNextObjectBase
    {
        public ERPPricing_rule_detail() : this(new ERPObject(DocType.Pricing_rule_detail)) { }
        public ERPPricing_rule_detail(ERPObject obj) : base(obj) { }

        public static ERPPricing_rule_detail Create(string pricingrule, string itemcode, string margintype, string rateordiscount, string childdocname, int ruleapplied)

        {
            ERPPricing_rule_detail obj = new ERPPricing_rule_detail();
            obj.pricing_rule = pricingrule;
            obj.item_code = itemcode;
            obj.margin_type = margintype;
            obj.rate_or_discount = rateordiscount;
            obj.child_docname = childdocname;
            obj.rule_applied = ruleapplied;
            return obj;
        }

        public string pricing_rule
        {
            get { return data.pricing_rule; }
            set
            {
                data.pricing_rule = value;
                data.name = value;
            }

        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string margin_type
        {
            get { return data.margin_type; }
            set { data.margin_type = value; }
        }

        public string rate_or_discount
        {
            get { return data.rate_or_discount; }
            set { data.rate_or_discount = value; }
        }

        public string child_docname
        {
            get { return data.child_docname; }
            set { data.child_docname = value; }
        }

        private int _rule_applied = 0;
        public int rule_applied
        {
            get { return data._rule_applied; }
            set { data._rule_applied = value; }
        }


    }

    //Enums go here

}