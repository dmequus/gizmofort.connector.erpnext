using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_taxes_and_charges
{
    public class ERPSales_taxes_and_charges : ERPNextObjectBase
    {
        public ERPSales_taxes_and_charges() : this(new ERPObject(DocType.Sales_taxes_and_charges)) { }
        public ERPSales_taxes_and_charges(ERPObject obj) : base(obj) { }

        public static ERPSales_taxes_and_charges Create(Chargetype chargetype, string accounthead, string description)

        {
            ERPSales_taxes_and_charges obj = new ERPSales_taxes_and_charges();
            obj.charge_type = chargetype;
            obj.account_head = accounthead;
            obj.description = description;
            return obj;
        }

        public Chargetype charge_type
        {
            get { return parseEnum<Chargetype>(data.charge_type); }
            set { data.charge_type = value.ToString(); }
        }

        public string account_head
        {
            get { return data.account_head; }
            set { data.account_head = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string row_id
        {
            get { return data.row_id; }
            set { data.row_id = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public long included_in_print_rate
        {
            get { return data.included_in_print_rate; }
            set { data.included_in_print_rate = value; }
        }

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public double tax_amount
        {
            get { return data.tax_amount; }
            set { data.tax_amount = value; }
        }

        public double total
        {
            get { return data.total; }
            set { data.total = value; }
        }

        public double tax_amount_after_discount_amount
        {
            get { return data.tax_amount_after_discount_amount; }
            set { data.tax_amount_after_discount_amount = value; }
        }

        public double base_tax_amount
        {
            get { return data.base_tax_amount; }
            set { data.base_tax_amount = value; }
        }

        public double base_total
        {
            get { return data.base_total; }
            set { data.base_total = value; }
        }

        public double base_tax_amount_after_discount_amount
        {
            get { return data.base_tax_amount_after_discount_amount; }
            set { data.base_tax_amount_after_discount_amount = value; }
        }

        public string item_wise_tax_detail
        {
            get { return data.item_wise_tax_detail; }
            set { data.item_wise_tax_detail = value; }
        }

        public string parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = value; }
        }


    }

    //Enums go here
    public enum Chargetype
    {
        [Description("Actual")]
        Actual,
        [Description("On Net Total")]
        OnNetTotal,
        [Description("On Previous Row Amount")]
        OnPreviousRowAmount,
        [Description("On Previous Row Total")]
        OnPreviousRowTotal,
        [Description("On Item Quantity")]
        OnItemQuantity,
    }


}