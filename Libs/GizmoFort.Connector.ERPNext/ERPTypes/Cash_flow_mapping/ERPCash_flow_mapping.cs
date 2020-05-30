using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping
{
    public class ERPCash_flow_mapping : ERPNextObjectBase
    {
        public ERPCash_flow_mapping() : this(new ERPObject(DocType.Cash_flow_mapping)) { }
        public ERPCash_flow_mapping(ERPObject obj) : base(obj) { }

        public static ERPCash_flow_mapping Create(string mappingname, string label, string accounts, int isfinancecost, int isworkingcapital, int isfinancecostadjustment, int isincometaxliability, int isincometaxexpense)

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

        private int _is_finance_cost = 0;
        public int is_finance_cost
        {
            get { return data._is_finance_cost; }
            set { data._is_finance_cost = value; }
        }

        private int _is_working_capital = 0;
        public int is_working_capital
        {
            get { return data._is_working_capital; }
            set { data._is_working_capital = value; }
        }

        private int _is_finance_cost_adjustment = 0;
        public int is_finance_cost_adjustment
        {
            get { return data._is_finance_cost_adjustment; }
            set { data._is_finance_cost_adjustment = value; }
        }

        private int _is_income_tax_liability = 0;
        public int is_income_tax_liability
        {
            get { return data._is_income_tax_liability; }
            set { data._is_income_tax_liability = value; }
        }

        private int _is_income_tax_expense = 0;
        public int is_income_tax_expense
        {
            get { return data._is_income_tax_expense; }
            set { data._is_income_tax_expense = value; }
        }


    }

    //Enums go here

}