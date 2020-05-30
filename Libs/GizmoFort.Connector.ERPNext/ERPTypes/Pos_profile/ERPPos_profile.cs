using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_profile
{
    public class ERPPos_profile : ERPNextObjectBase
    {
        public ERPPos_profile() : this(new ERPObject(DocType.Pos_profile)) { }
        public ERPPos_profile(ERPObject obj) : base(obj) { }

        public static ERPPos_profile Create(string namingseries, string company, string territory, string customergroup, string currency, string writeoffaccount, string writeoffcostcenter)

        {
            ERPPos_profile obj = new ERPPos_profile();
            obj.naming_series = namingseries;
            obj.company = company;
            obj.territory = territory;
            obj.customer_group = customergroup;
            obj.currency = currency;
            obj.write_off_account = writeoffaccount;
            obj.write_off_cost_center = writeoffcostcenter;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public string write_off_account
        {
            get { return data.write_off_account; }
            set { data.write_off_account = value; }
        }

        public string write_off_cost_center
        {
            get { return data.write_off_cost_center; }
            set { data.write_off_cost_center = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        public string company_address
        {
            get { return data.company_address; }
            set { data.company_address = value; }
        }

        public long update_stock
        {
            get { return data.update_stock; }
            set { data.update_stock = value; }
        }

        public long ignore_pricing_rule
        {
            get { return data.ignore_pricing_rule; }
            set { data.ignore_pricing_rule = value; }
        }

        public long allow_delete
        {
            get { return data.allow_delete; }
            set { data.allow_delete = value; }
        }

        public long allow_user_to_edit_rate
        {
            get { return data.allow_user_to_edit_rate; }
            set { data.allow_user_to_edit_rate = value; }
        }

        public long allow_user_to_edit_discount
        {
            get { return data.allow_user_to_edit_discount; }
            set { data.allow_user_to_edit_discount = value; }
        }

        public long allow_print_before_pay
        {
            get { return data.allow_print_before_pay; }
            set { data.allow_print_before_pay = value; }
        }

        public long display_items_in_stock
        {
            get { return data.display_items_in_stock; }
            set { data.display_items_in_stock = value; }
        }

        public string applicable_for_users
        {
            get { return data.applicable_for_users; }
            set { data.applicable_for_users = value; }
        }

        public string payments
        {
            get { return data.payments; }
            set { data.payments = value; }
        }

        public string item_groups
        {
            get { return data.item_groups; }
            set { data.item_groups = value; }
        }

        public string customer_groups
        {
            get { return data.customer_groups; }
            set { data.customer_groups = value; }
        }

        public string print_format_for_online
        {
            get { return data.print_format_for_online; }
            set { data.print_format_for_online = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string tc_name
        {
            get { return data.tc_name; }
            set { data.tc_name = value; }
        }

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        public string print_format
        {
            get { return data.print_format; }
            set { data.print_format = value; }
        }

        public string selling_price_list
        {
            get { return data.selling_price_list; }
            set { data.selling_price_list = value; }
        }

        public string account_for_change_amount
        {
            get { return data.account_for_change_amount; }
            set { data.account_for_change_amount = value; }
        }

        public string income_account
        {
            get { return data.income_account; }
            set { data.income_account = value; }
        }

        public string expense_account
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string taxes_and_charges
        {
            get { return data.taxes_and_charges; }
            set { data.taxes_and_charges = value; }
        }

        public Applydiscounton apply_discount_on
        {
            get { return parseEnum<Applydiscounton>(data.apply_discount_on); }
            set { data.apply_discount_on = value.ToString(); }
        }

        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }


    }

    //Enums go here
    public enum Applydiscounton
    {
        [Description("Grand Total")]
        GrandTotal,
        [Description("Net Total")]
        NetTotal,
    }


}