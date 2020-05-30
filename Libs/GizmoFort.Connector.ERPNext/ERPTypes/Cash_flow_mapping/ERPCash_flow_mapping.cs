using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping
{
    public class ERPCash_flow_mapping : ERPNextObjectBase
    {
        public ERPCash_flow_mapping() : this(new ERPObject(DocType.Cash_flow_mapping)) { }
        public ERPCash_flow_mapping(ERPObject obj) : base(obj) { }

        public static ERPCash_flow_mapping Create(string mappingname, string label, string accounts, long isfinancecost, long isworkingcapital, long isfinancecostadjustment, long isincometaxliability, long isincometaxexpense)

        {
            ERPCash_flow_mapping obj = new ERPCash_flow_mapping();
            obj.mapping_name = mappingname;
            obj.label = label;
            obj.accounts = accounts;
            obj.is_finance_cost = isfinancecost;
            obj.is_working_capital = isworkingcapital;
            obj.is_finance_cost_adjustment = isfinancecostadjustment;
            obj.is_income_tax_liability = isincometaxliability;
            obj.is_income_tax_expense = isincometaxexpense;
            return obj;
        }

        public string mapping_name
        {
            get { return data.mapping_name; }
            set
            {
                data.mapping_name = value;
                data.name = value;
            }

        }

        public string label
        {
            get { return data.label; }
            set { data.label = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public long is_finance_cost
        {
            get { return data.is_finance_cost; }
            set { data.is_finance_cost = value; }
        }

        public long is_working_capital
        {
            get { return data.is_working_capital; }
            set { data.is_working_capital = value; }
        }

        public long is_finance_cost_adjustment
        {
            get { return data.is_finance_cost_adjustment; }
            set { data.is_finance_cost_adjustment = value; }
        }

        public long is_income_tax_liability
        {
            get { return data.is_income_tax_liability; }
            set { data.is_income_tax_liability = value; }
        }

        public long is_income_tax_expense
        {
            get { return data.is_income_tax_expense; }
            set { data.is_income_tax_expense = value; }
        }


    }

    //Enums go here

}