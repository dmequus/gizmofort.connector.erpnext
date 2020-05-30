using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription
{
    public class ERPSubscription : ERPNextObjectBase
    {
        public ERPSubscription() : this(new ERPObject(DocType.Subscription)) { }
        public ERPSubscription(ERPObject obj) : base(obj) { }

        public static ERPSubscription Create(string customer, string plans)

        {
            ERPSubscription obj = new ERPSubscription();
            obj.customer = customer;
            obj.plans = plans;
            return obj;
        }

        public string customer
        {
            get { return data.customer; }
            set
            {
                data.customer = value;
                data.name = value;
            }

        }

        public string plans
        {
            get { return data.plans; }
            set { data.plans = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string start
        {
            get { return data.start; }
            set { data.start = value; }
        }

        public string cancelation_date
        {
            get { return data.cancelation_date; }
            set { data.cancelation_date = value; }
        }

        public string trial_period_start
        {
            get { return data.trial_period_start; }
            set { data.trial_period_start = value; }
        }

        public string trial_period_end
        {
            get { return data.trial_period_end; }
            set { data.trial_period_end = value; }
        }

        public string current_invoice_start
        {
            get { return data.current_invoice_start; }
            set { data.current_invoice_start = value; }
        }

        public string current_invoice_end
        {
            get { return data.current_invoice_end; }
            set { data.current_invoice_end = value; }
        }

        private int _days_until_due = 0;
        public int days_until_due
        {
            get { return data._days_until_due; }
            set { data._days_until_due = value; }
        }

        private int _cancel_at_period_end = 0;
        public int cancel_at_period_end
        {
            get { return data._cancel_at_period_end; }
            set { data._cancel_at_period_end = value; }
        }

        private int _generate_invoice_at_period_start = 0;
        public int generate_invoice_at_period_start
        {
            get { return data._generate_invoice_at_period_start; }
            set { data._generate_invoice_at_period_start = value; }
        }

        public string tax_template
        {
            get { return data.tax_template; }
            set { data.tax_template = value; }
        }

        public Applyadditionaldiscount apply_additional_discount
        {
            get { return parseEnum<Applyadditionaldiscount>(data.apply_additional_discount); }
            set { data.apply_additional_discount = value.ToString(); }
        }

        private double _additional_discount_percentage = 0.0;
        public double additional_discount_percentage
        {
            get { return data._additional_discount_percentage; }
            set { data._additional_discount_percentage = value; }
        }

        private double _additional_discount_amount = 0.0;
        public double additional_discount_amount
        {
            get { return data._additional_discount_amount; }
            set { data._additional_discount_amount = value; }
        }

        public string invoices
        {
            get { return data.invoices; }
            set { data.invoices = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Trialling")]
        Trialling,
        [Description("Active")]
        Active,
        [Description("Past Due Date")]
        PastDueDate,
        [Description("Cancelled")]
        Cancelled,
        [Description("Unpaid")]
        Unpaid,
    }

    public enum Applyadditionaldiscount
    {
        [Description("Grand Total")]
        GrandTotal,
        [Description("Net Total")]
        NetTotal,
    }


}