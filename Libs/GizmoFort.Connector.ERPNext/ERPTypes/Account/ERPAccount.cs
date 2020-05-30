using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Account
{
    public class ERPAccount : ERPNextObjectBase
    {
        public ERPAccount() : this(new ERPObject(DocType.Account)) { }
        public ERPAccount(ERPObject obj) : base(obj) { }

        public static ERPAccount Create(string accountname, string company, string parentaccount)

        {
            ERPAccount obj = new ERPAccount();
            obj.account_name = accountname;
            obj.company = company;
            obj.parent_account = parentaccount;
            return obj;
        }

        public string account_name
        {
            get { return data.account_name; }
            set
            {
                data.account_name = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string parent_account
        {
            get { return data.parent_account; }
            set { data.parent_account = value; }
        }

        public string account_number
        {
            get { return data.account_number; }
            set { data.account_number = value; }
        }

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        public Roottype root_type
        {
            get { return parseEnum<Roottype>(data.root_type); }
            set { data.root_type = value.ToString(); }
        }

        public Reporttype report_type
        {
            get { return parseEnum<Reporttype>(data.report_type); }
            set { data.report_type = value.ToString(); }
        }

        public string account_currency
        {
            get { return data.account_currency; }
            set { data.account_currency = value; }
        }

        public long inter_company_account
        {
            get { return data.inter_company_account; }
            set { data.inter_company_account = value; }
        }

        public Accounttype account_type
        {
            get { return parseEnum<Accounttype>(data.account_type); }
            set { data.account_type = value.ToString(); }
        }

        public double tax_rate
        {
            get { return data.tax_rate; }
            set { data.tax_rate = value; }
        }

        public Freezeaccount freeze_account
        {
            get { return parseEnum<Freezeaccount>(data.freeze_account); }
            set { data.freeze_account = value.ToString(); }
        }

        public Balancemustbe balance_must_be
        {
            get { return parseEnum<Balancemustbe>(data.balance_must_be); }
            set { data.balance_must_be = value.ToString(); }
        }

        public int lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        public int rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        public long include_in_gross
        {
            get { return data.include_in_gross; }
            set { data.include_in_gross = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }


    }

    //Enums go here
    public enum Roottype
    {
        [Description("Asset")]
        Asset,
        [Description("Liability")]
        Liability,
        [Description("Income")]
        Income,
        [Description("Expense")]
        Expense,
        [Description("Equity")]
        Equity,
    }

    public enum Reporttype
    {
        [Description("Balance Sheet")]
        BalanceSheet,
        [Description("Profit and Loss")]
        ProfitandLoss,
    }

    public enum Accounttype
    {
        [Description("Accumulated Depreciation")]
        AccumulatedDepreciation,
        [Description("Asset Received But Not Billed")]
        AssetReceivedButNotBilled,
        [Description("Bank")]
        Bank,
        [Description("Cash")]
        Cash,
        [Description("Chargeable")]
        Chargeable,
        [Description("Capital Work in Progress")]
        CapitalWorkinProgress,
        [Description("Cost of Goods Sold")]
        CostofGoodsSold,
        [Description("Depreciation")]
        Depreciation,
        [Description("Equity")]
        Equity,
        [Description("Expense Account")]
        ExpenseAccount,
        [Description("Expenses Included In Asset Valuation")]
        ExpensesIncludedInAssetValuation,
        [Description("Expenses Included In Valuation")]
        ExpensesIncludedInValuation,
        [Description("Fixed Asset")]
        FixedAsset,
        [Description("Income Account")]
        IncomeAccount,
        [Description("Payable")]
        Payable,
        [Description("Receivable")]
        Receivable,
        [Description("Round Off")]
        RoundOff,
        [Description("Stock")]
        Stock,
        [Description("Stock Adjustment")]
        StockAdjustment,
        [Description("Stock Received But Not Billed")]
        StockReceivedButNotBilled,
        [Description("Tax")]
        Tax,
        [Description("Temporary")]
        Temporary,
    }

    public enum Freezeaccount
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }

    public enum Balancemustbe
    {
        [Description("Debit")]
        Debit,
        [Description("Credit")]
        Credit,
    }


}