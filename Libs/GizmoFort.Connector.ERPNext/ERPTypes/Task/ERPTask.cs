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

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
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

        public double expected_time
        {
            get { return data.expected_time; }
            set { data.expected_time = value; }
        }

        public double task_weight
        {
            get { return data.task_weight; }
            set { data.task_weight = value; }
        }

        public string exp_end_date
        {
            get { return data.exp_end_date; }
            set { data.exp_end_date = value; }
        }

        public double progress
        {
            get { return data.progress; }
            set { data.progress = value; }
        }

        public long is_milestone
        {
            get { return data.is_milestone; }
            set { data.is_milestone = value; }
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

        public double actual_time
        {
            get { return data.actual_time; }
            set { data.actual_time = value; }
        }

        public string act_end_date
        {
            get { return data.act_end_date; }
            set { data.act_end_date = value; }
        }

        public double total_costing_amount
        {
            get { return data.total_costing_amount; }
            set { data.total_costing_amount = value; }
        }

        public double total_expense_claim
        {
            get { return data.total_expense_claim; }
            set { data.total_expense_claim = value; }
        }

        public double total_billing_amount
        {
            get { return data.total_billing_amount; }
            set { data.total_billing_amount = value; }
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