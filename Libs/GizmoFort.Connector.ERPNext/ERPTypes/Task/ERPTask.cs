using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Task
{
    public class ERPTask : ERPNextObjectBase
    {
        public ERPTask() : this(new ERPObject(DocType.Task)) { }
        public ERPTask(ERPObject obj) : base(obj) { }

        public static ERPTask Create(string subject)

        {
            ERPTask obj = new ERPTask();
            obj.subject = subject;
            return obj;
        }

        public string subject
        {
            get { return data.subject; }
            set
            {
                data.subject = value;
                data.name = value;
            }

        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string issue
        {
            get { return data.issue; }
            set { data.issue = value; }
        }

        public string type
        {
            get { return data.type; }
            set { data.type = value; }
        }

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public Priority priority
        {
            get { return parseEnum<Priority>(data.priority); }
            set { data.priority = value.ToString(); }
        }

        public string color
        {
            get { return data.color; }
            set { data.color = value; }
        }

        public string parent_task
        {
            get { return data.parent_task; }
            set { data.parent_task = value; }
        }

        public string exp_start_date
        {
            get { return data.exp_start_date; }
            set { data.exp_start_date = value; }
        }

        private double _expected_time = 0.0;
        public double expected_time
        {
            get { return data._expected_time; }
            set { data._expected_time = value; }
        }

        private double _task_weight = 0.0;
        public double task_weight
        {
            get { return data._task_weight; }
            set { data._task_weight = value; }
        }

        public string exp_end_date
        {
            get { return data.exp_end_date; }
            set { data.exp_end_date = value; }
        }

        private double _progress = 0.0;
        public double progress
        {
            get { return data._progress; }
            set { data._progress = value; }
        }

        private int _is_milestone = 0;
        public int is_milestone
        {
            get { return data._is_milestone; }
            set { data._is_milestone = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string depends_on
        {
            get { return data.depends_on; }
            set { data.depends_on = value; }
        }

        public string depends_on_tasks
        {
            get { return data.depends_on_tasks; }
            set { data.depends_on_tasks = value; }
        }

        public string act_start_date
        {
            get { return data.act_start_date; }
            set { data.act_start_date = value; }
        }

        private double _actual_time = 0.0;
        public double actual_time
        {
            get { return data._actual_time; }
            set { data._actual_time = value; }
        }

        public string act_end_date
        {
            get { return data.act_end_date; }
            set { data.act_end_date = value; }
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

        private double _total_billing_amount = 0.0;
        public double total_billing_amount
        {
            get { return data._total_billing_amount; }
            set { data._total_billing_amount = value; }
        }

        public string review_date
        {
            get { return data.review_date; }
            set { data.review_date = value; }
        }

        public string closing_date
        {
            get { return data.closing_date; }
            set { data.closing_date = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        public string completed_by
        {
            get { return data.completed_by; }
            set { data.completed_by = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Working")]
        Working,
        [Description("Pending Review")]
        PendingReview,
        [Description("Overdue")]
        Overdue,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }

    public enum Priority
    {
        [Description("Low")]
        Low,
        [Description("Medium")]
        Medium,
        [Description("High")]
        High,
        [Description("Urgent")]
        Urgent,
    }


}