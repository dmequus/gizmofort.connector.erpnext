using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Project
{
    public class ERPProject : ERPNextObjectBase
    {
        public ERPProject() : this(new ERPObject(DocType.Project)) { }
        public ERPProject(ERPObject obj) : base(obj) { }

        public static ERPProject Create(string projectname)

        {
            ERPProject obj = new ERPProject();
            obj.project_name = projectname;
            return obj;
        }

        public string project_name
        {
            get { return data.project_name; }
            set
            {
                data.project_name = value;
                data.name = value;
            }

        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string project_type
        {
            get { return data.project_type; }
            set { data.project_type = value; }
        }

        public Isactive is_active
        {
            get { return parseEnum<Isactive>(data.is_active); }
            set { data.is_active = value.ToString(); }
        }

        public Percentcompletemethod percent_complete_method
        {
            get { return parseEnum<Percentcompletemethod>(data.percent_complete_method); }
            set { data.percent_complete_method = value.ToString(); }
        }

        private double _percent_complete = 0.0;
        public double percent_complete
        {
            get { return data._percent_complete; }
            set { data._percent_complete = value; }
        }

        public string project_template
        {
            get { return data.project_template; }
            set { data.project_template = value; }
        }

        public string expected_start_date
        {
            get { return data.expected_start_date; }
            set { data.expected_start_date = value; }
        }

        public string expected_end_date
        {
            get { return data.expected_end_date; }
            set { data.expected_end_date = value; }
        }

        public Priority priority
        {
            get { return parseEnum<Priority>(data.priority); }
            set { data.priority = value.ToString(); }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        public string users
        {
            get { return data.users; }
            set { data.users = value; }
        }

        public string copied_from
        {
            get { return data.copied_from; }
            set { data.copied_from = value; }
        }

        public string notes
        {
            get { return data.notes; }
            set { data.notes = value; }
        }

        public string actual_start_date
        {
            get { return data.actual_start_date; }
            set { data.actual_start_date = value; }
        }

        private double _actual_time = 0.0;
        public double actual_time
        {
            get { return data._actual_time; }
            set { data._actual_time = value; }
        }

        public string actual_end_date
        {
            get { return data.actual_end_date; }
            set { data.actual_end_date = value; }
        }

        private double _estimated_costing = 0.0;
        public double estimated_costing
        {
            get { return data._estimated_costing; }
            set { data._estimated_costing = value; }
        }

        private double _total_costing_amount = 0.0;
        public double total_costing_amount
        {
            get { return data._total_costing_amount; }
            set { data._total_costing_amount = value; }
        }

        private double _total_expense_claim = 0.0;
        public double total_expense_claim
        {
            get { return data._total_expense_claim; }
            set { data._total_expense_claim = value; }
        }

        private double _total_purchase_cost = 0.0;
        public double total_purchase_cost
        {
            get { return data._total_purchase_cost; }
            set { data._total_purchase_cost = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private double _total_sales_amount = 0.0;
        public double total_sales_amount
        {
            get { return data._total_sales_amount; }
            set { data._total_sales_amount = value; }
        }

        private double _total_billable_amount = 0.0;
        public double total_billable_amount
        {
            get { return data._total_billable_amount; }
            set { data._total_billable_amount = value; }
        }

        private double _total_billed_amount = 0.0;
        public double total_billed_amount
        {
            get { return data._total_billed_amount; }
            set { data._total_billed_amount = value; }
        }

        private double _total_consumed_material_cost = 0.0;
        public double total_consumed_material_cost
        {
            get { return data._total_consumed_material_cost; }
            set { data._total_consumed_material_cost = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        private double _gross_margin = 0.0;
        public double gross_margin
        {
            get { return data._gross_margin; }
            set { data._gross_margin = value; }
        }

        private double _per_gross_margin = 0.0;
        public double per_gross_margin
        {
            get { return data._per_gross_margin; }
            set { data._per_gross_margin = value; }
        }

        private int _collect_progress = 0;
        public int collect_progress
        {
            get { return data._collect_progress; }
            set { data._collect_progress = value; }
        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        public Frequency frequency
        {
            get { return parseEnum<Frequency>(data.frequency); }
            set { data.frequency = value.ToString(); }
        }

        public string from_time
        {
            get { return data.from_time; }
            set { data.from_time = value; }
        }

        public string to_time
        {
            get { return data.to_time; }
            set { data.to_time = value; }
        }

        public string first_email
        {
            get { return data.first_email; }
            set { data.first_email = value; }
        }

        public string second_email
        {
            get { return data.second_email; }
            set { data.second_email = value; }
        }

        public string daily_time_to_send
        {
            get { return data.daily_time_to_send; }
            set { data.daily_time_to_send = value; }
        }

        public Daytosend day_to_send
        {
            get { return parseEnum<Daytosend>(data.day_to_send); }
            set { data.day_to_send = value.ToString(); }
        }

        public string weekly_time_to_send
        {
            get { return data.weekly_time_to_send; }
            set { data.weekly_time_to_send = value; }
        }

        public string message
        {
            get { return data.message; }
            set { data.message = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }

    public enum Isactive
    {
        [Description("Yes")]
        Yes,
        [Description("No")]
        No,
    }

    public enum Percentcompletemethod
    {
        [Description("Manual")]
        Manual,
        [Description("Task Completion")]
        TaskCompletion,
        [Description("Task Progress")]
        TaskProgress,
        [Description("Task Weight")]
        TaskWeight,
    }

    public enum Priority
    {
        [Description("Medium")]
        Medium,
        [Description("Low")]
        Low,
        [Description("High")]
        High,
    }

    public enum Frequency
    {
        [Description("Hourly")]
        Hourly,
        [Description("Twice Daily")]
        TwiceDaily,
        [Description("Daily")]
        Daily,
        [Description("Weekly")]
        Weekly,
    }

    public enum Daytosend
    {
        [Description("Monday")]
        Monday,
        [Description("Tuesday")]
        Tuesday,
        [Description("Wednesday")]
        Wednesday,
        [Description("Thursday")]
        Thursday,
        [Description("Friday")]
        Friday,
        [Description("Saturday")]
        Saturday,
        [Description("Sunday")]
        Sunday,
    }


}