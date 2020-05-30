using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Budget
{
    public class ERPBudget : ERPNextObjectBase
    {
        public ERPBudget() : this(new ERPObject(DocType.Budget)) { }
        public ERPBudget(ERPObject obj) : base(obj) { }

        public static ERPBudget Create(Budgetagainst budgetagainst, string company, string costcenter, string project, string fiscalyear, string monthlydistribution, string amendedfrom, long applicableonmaterialrequest, Actionifannualbudgetexceededonmr actionifannualbudgetexceededonmr, Actionifaccumulatedmonthlybudgetexceededonmr actionifaccumulatedmonthlybudgetexceededonmr, long applicableonpurchaseorder, Actionifannualbudgetexceededonpo actionifannualbudgetexceededonpo, Actionifaccumulatedmonthlybudgetexceededonpo actionifaccumulatedmonthlybudgetexceededonpo, long applicableonbookingactualexpenses, Actionifannualbudgetexceeded actionifannualbudgetexceeded, Actionifaccumulatedmonthlybudgetexceeded actionifaccumulatedmonthlybudgetexceeded, string accounts)

        {
            ERPBudget obj = new ERPBudget();
            obj.budget_against = budgetagainst;
            obj.company = company;
            obj.cost_center = costcenter;
            obj.project = project;
            obj.fiscal_year = fiscalyear;
            obj.monthly_distribution = monthlydistribution;
            obj.amended_from = amendedfrom;
            obj.applicable_on_material_request = applicableonmaterialrequest;
            obj.action_if_annual_budget_exceeded_on_mr = actionifannualbudgetexceededonmr;
            obj.action_if_accumulated_monthly_budget_exceeded_on_mr = actionifaccumulatedmonthlybudgetexceededonmr;
            obj.applicable_on_purchase_order = applicableonpurchaseorder;
            obj.action_if_annual_budget_exceeded_on_po = actionifannualbudgetexceededonpo;
            obj.action_if_accumulated_monthly_budget_exceeded_on_po = actionifaccumulatedmonthlybudgetexceededonpo;
            obj.applicable_on_booking_actual_expenses = applicableonbookingactualexpenses;
            obj.action_if_annual_budget_exceeded = actionifannualbudgetexceeded;
            obj.action_if_accumulated_monthly_budget_exceeded = actionifaccumulatedmonthlybudgetexceeded;
            obj.accounts = accounts;
            return obj;
        }

        public Budgetagainst budget_against
        {
            get { return parseEnum<Budgetagainst>(data.budget_against); }
            set { data.budget_against = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string fiscal_year
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        public string monthly_distribution
        {
            get { return data.monthly_distribution; }
            set { data.monthly_distribution = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public long applicable_on_material_request
        {
            get { return data.applicable_on_material_request; }
            set { data.applicable_on_material_request = value; }
        }

        public Actionifannualbudgetexceededonmr action_if_annual_budget_exceeded_on_mr
        {
            get { return parseEnum<Actionifannualbudgetexceededonmr>(data.action_if_annual_budget_exceeded_on_mr); }
            set { data.action_if_annual_budget_exceeded_on_mr = value.ToString(); }
        }

        public Actionifaccumulatedmonthlybudgetexceededonmr action_if_accumulated_monthly_budget_exceeded_on_mr
        {
            get { return parseEnum<Actionifaccumulatedmonthlybudgetexceededonmr>(data.action_if_accumulated_monthly_budget_exceeded_on_mr); }
            set { data.action_if_accumulated_monthly_budget_exceeded_on_mr = value.ToString(); }
        }

        public long applicable_on_purchase_order
        {
            get { return data.applicable_on_purchase_order; }
            set { data.applicable_on_purchase_order = value; }
        }

        public Actionifannualbudgetexceededonpo action_if_annual_budget_exceeded_on_po
        {
            get { return parseEnum<Actionifannualbudgetexceededonpo>(data.action_if_annual_budget_exceeded_on_po); }
            set { data.action_if_annual_budget_exceeded_on_po = value.ToString(); }
        }

        public Actionifaccumulatedmonthlybudgetexceededonpo action_if_accumulated_monthly_budget_exceeded_on_po
        {
            get { return parseEnum<Actionifaccumulatedmonthlybudgetexceededonpo>(data.action_if_accumulated_monthly_budget_exceeded_on_po); }
            set { data.action_if_accumulated_monthly_budget_exceeded_on_po = value.ToString(); }
        }

        public long applicable_on_booking_actual_expenses
        {
            get { return data.applicable_on_booking_actual_expenses; }
            set { data.applicable_on_booking_actual_expenses = value; }
        }

        public Actionifannualbudgetexceeded action_if_annual_budget_exceeded
        {
            get { return parseEnum<Actionifannualbudgetexceeded>(data.action_if_annual_budget_exceeded); }
            set { data.action_if_annual_budget_exceeded = value.ToString(); }
        }

        public Actionifaccumulatedmonthlybudgetexceeded action_if_accumulated_monthly_budget_exceeded
        {
            get { return parseEnum<Actionifaccumulatedmonthlybudgetexceeded>(data.action_if_accumulated_monthly_budget_exceeded); }
            set { data.action_if_accumulated_monthly_budget_exceeded = value.ToString(); }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }


    }

    //Enums go here
    public enum Budgetagainst
    {
        [Description("Cost Center")]
        CostCenter,
        [Description("Project")]
        Project,
    }

    public enum Actionifannualbudgetexceededonmr
    {
        [Description("Stop")]
        Stop,
        [Description("Warn")]
        Warn,
        [Description("Ignore")]
        Ignore,
    }

    public enum Actionifaccumulatedmonthlybudgetexceededonmr
    {
        [Description("Stop")]
        Stop,
        [Description("Warn")]
        Warn,
        [Description("Ignore")]
        Ignore,
    }

    public enum Actionifannualbudgetexceededonpo
    {
        [Description("Stop")]
        Stop,
        [Description("Warn")]
        Warn,
        [Description("Ignore")]
        Ignore,
    }

    public enum Actionifaccumulatedmonthlybudgetexceededonpo
    {
        [Description("Stop")]
        Stop,
        [Description("Warn")]
        Warn,
        [Description("Ignore")]
        Ignore,
    }

    public enum Actionifannualbudgetexceeded
    {
        [Description("Stop")]
        Stop,
        [Description("Warn")]
        Warn,
        [Description("Ignore")]
        Ignore,
    }

    public enum Actionifaccumulatedmonthlybudgetexceeded
    {
        [Description("Stop")]
        Stop,
        [Description("Warn")]
        Warn,
        [Description("Ignore")]
        Ignore,
    }


}