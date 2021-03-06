using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_taxes_and_charges
{
    public class ERPPurchase_taxes_and_charges : ERPNextObjectBase
    {
        public ERPPurchase_taxes_and_charges() : this(new ERPObject(DocType.Purchase_taxes_and_charges)) { }
        public ERPPurchase_taxes_and_charges(ERPObject obj) : base(obj) { }

        public static ERPPurchase_taxes_and_charges Create(Category category, Adddeducttax adddeducttax, Chargetype chargetype, string accounthead, string description)

        {
            ERPPurchase_taxes_and_charges obj = new ERPPurchase_taxes_and_charges();
            obj.category = category;
            obj.add_deduct_tax = adddeducttax;
            obj.charge_type = chargetype;
            obj.account_head = accounthead;
            obj.description = description;
            return obj;
        }

        public Category category
        {
            get { return parseEnum<Category>(data.category); }
            set { data.category = value.ToString(); }
        }

        public Adddeducttax add_deduct_tax
        {
            get { return parseEnum<Adddeducttax>(data.add_deduct_tax); }
            set { data.add_deduct_tax = value.ToString(); }
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

        public long included_in_print_rate
        {
            get { return data.included_in_print_rate; }
            set { data.included_in_print_rate = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
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

        public double tax_amount_after_discount_amount
        {
            get { return data.tax_amount_after_discount_amount; }
            set { data.tax_amount_after_discount_amount = value; }
        }

        public double total
        {
            get { return data.total; }
            set { data.total = value; }
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


    }

    //Enums go here
    public enum Category
    {
        [Description("Valuation and Total")]
        ValuationandTotal,
        [Description("Valuation")]
        Valuation,
        [Description("Total")]
        Total,
    }

    public enum Adddeducttax
    {
        [Description("Add")]
        Add,
        [Description("Deduct")]
        Deduct,
    }

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