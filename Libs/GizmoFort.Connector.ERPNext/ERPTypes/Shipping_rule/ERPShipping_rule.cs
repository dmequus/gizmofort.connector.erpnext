using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shipping_rule
{
    public class ERPShipping_rule : ERPNextObjectBase
    {
        public ERPShipping_rule() : this(new ERPObject(DocType.Shipping_rule)) { }
        public ERPShipping_rule(ERPObject obj) : base(obj) { }

        public static ERPShipping_rule Create(string label, string company, string account, string costcenter)

        {
            ERPShipping_rule obj = new ERPShipping_rule();
            obj.label = label;
            obj.company = company;
            obj.account = account;
            obj.cost_center = costcenter;
            return obj;
        }

        public string label
        {
            get { return data.label; }
            set
            {
                data.label = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public Shippingruletype shipping_rule_type
        {
            get { return parseEnum<Shippingruletype>(data.shipping_rule_type); }
            set { data.shipping_rule_type = value.ToString(); }
        }

        public Calculatebasedon calculate_based_on
        {
            get { return parseEnum<Calculatebasedon>(data.calculate_based_on); }
            set { data.calculate_based_on = value.ToString(); }
        }

        public double shipping_amount
        {
            get { return data.shipping_amount; }
            set { data.shipping_amount = value; }
        }

        public string conditions
        {
            get { return data.conditions; }
            set { data.conditions = value; }
        }

        public string countries
        {
            get { return data.countries; }
            set { data.countries = value; }
        }


    }

    //Enums go here
    public enum Shippingruletype
    {
        [Description("Selling")]
        Selling,
        [Description("Buying")]
        Buying,
    }

    public enum Calculatebasedon
    {
        [Description("Fixed")]
        Fixed,
        [Description("Net Total")]
        NetTotal,
        [Description("Net Weight")]
        NetWeight,
    }


}