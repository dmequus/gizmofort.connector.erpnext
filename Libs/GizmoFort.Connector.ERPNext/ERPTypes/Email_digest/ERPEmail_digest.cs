using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Email_digest
{
    public class ERPEmail_digest : ERPNextObjectBase
    {
        public ERPEmail_digest() : this(new ERPObject(DocType.Email_digest)) { }
        public ERPEmail_digest(ERPObject obj) : base(obj) { }

        public static ERPEmail_digest Create(int enabled, string company, Frequency frequency, string nextsend, string recipientlist, int income, int expensesbooked, int incomeyeartodate, int expenseyeartodate, int bankbalance, int creditbalance, int invoicedamount, int payables, int salesorderstobill, int purchaseorderstobill, int salesorder, int purchaseorder, int salesorderstodeliver, int purchaseorderstoreceive, int salesinvoice, int purchaseinvoice, int newquotations, int pendingquotations, int issue, int project, int purchaseordersitemsoverdue, int calendarevents, int todolist, int notifications, int addquote)

        {
            ERPEmail_digest obj = new ERPEmail_digest();
            obj.enabled = enabled;
            obj.company = company;
            obj.frequency = frequency;
            obj.next_send = nextsend;
            obj.recipient_list = recipientlist;
            obj.income = income;
            obj.expenses_booked = expensesbooked;
            obj.income_year_to_date = incomeyeartodate;
            obj.expense_year_to_date = expenseyeartodate;
            obj.bank_balance = bankbalance;
            obj.credit_balance = creditbalance;
            obj.invoiced_amount = invoicedamount;
            obj.payables = payables;
            obj.sales_orders_to_bill = salesorderstobill;
            obj.purchase_orders_to_bill = purchaseorderstobill;
            obj.sales_order = salesorder;
            obj.purchase_order = purchaseorder;
            obj.sales_orders_to_deliver = salesorderstodeliver;
            obj.purchase_orders_to_receive = purchaseorderstoreceive;
            obj.sales_invoice = salesinvoice;
            obj.purchase_invoice = purchaseinvoice;
            obj.new_quotations = newquotations;
            obj.pending_quotations = pendingquotations;
            obj.issue = issue;
            obj.project = project;
            obj.purchase_orders_items_overdue = purchaseordersitemsoverdue;
            obj.calendar_events = calendarevents;
            obj.todo_list = todolist;
            obj.notifications = notifications;
            obj.add_quote = addquote;
            return obj;
        }

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public Frequency frequency
        {
            get { return parseEnum<Frequency>(data.frequency); }
            set { data.frequency = value.ToString(); }
        }

        public string next_send
        {
            get { return data.next_send; }
            set { data.next_send = value; }
        }

        public string recipient_list
        {
            get { return data.recipient_list; }
            set { data.recipient_list = value; }
        }

        private int _income = 0;
        public int income
        {
            get { return data._income; }
            set { data._income = value; }
        }

        private int _expenses_booked = 0;
        public int expenses_booked
        {
            get { return data._expenses_booked; }
            set { data._expenses_booked = value; }
        }

        private int _income_year_to_date = 0;
        public int income_year_to_date
        {
            get { return data._income_year_to_date; }
            set { data._income_year_to_date = value; }
        }

        private int _expense_year_to_date = 0;
        public int expense_year_to_date
        {
            get { return data._expense_year_to_date; }
            set { data._expense_year_to_date = value; }
        }

        private int _bank_balance = 0;
        public int bank_balance
        {
            get { return data._bank_balance; }
            set { data._bank_balance = value; }
        }

        private int _credit_balance = 0;
        public int credit_balance
        {
            get { return data._credit_balance; }
            set { data._credit_balance = value; }
        }

        private int _invoiced_amount = 0;
        public int invoiced_amount
        {
            get { return data._invoiced_amount; }
            set { data._invoiced_amount = value; }
        }

        private int _payables = 0;
        public int payables
        {
            get { return data._payables; }
            set { data._payables = value; }
        }

        private int _sales_orders_to_bill = 0;
        public int sales_orders_to_bill
        {
            get { return data._sales_orders_to_bill; }
            set { data._sales_orders_to_bill = value; }
        }

        private int _purchase_orders_to_bill = 0;
        public int purchase_orders_to_bill
        {
            get { return data._purchase_orders_to_bill; }
            set { data._purchase_orders_to_bill = value; }
        }

        private int _sales_order = 0;
        public int sales_order
        {
            get { return data._sales_order; }
            set { data._sales_order = value; }
        }

        private int _purchase_order = 0;
        public int purchase_order
        {
            get { return data._purchase_order; }
            set { data._purchase_order = value; }
        }

        private int _sales_orders_to_deliver = 0;
        public int sales_orders_to_deliver
        {
            get { return data._sales_orders_to_deliver; }
            set { data._sales_orders_to_deliver = value; }
        }

        private int _purchase_orders_to_receive = 0;
        public int purchase_orders_to_receive
        {
            get { return data._purchase_orders_to_receive; }
            set { data._purchase_orders_to_receive = value; }
        }

        private int _sales_invoice = 0;
        public int sales_invoice
        {
            get { return data._sales_invoice; }
            set { data._sales_invoice = value; }
        }

        private int _purchase_invoice = 0;
        public int purchase_invoice
        {
            get { return data._purchase_invoice; }
            set { data._purchase_invoice = value; }
        }

        private int _new_quotations = 0;
        public int new_quotations
        {
            get { return data._new_quotations; }
            set { data._new_quotations = value; }
        }

        private int _pending_quotations = 0;
        public int pending_quotations
        {
            get { return data._pending_quotations; }
            set { data._pending_quotations = value; }
        }

        private int _issue = 0;
        public int issue
        {
            get { return data._issue; }
            set { data._issue = value; }
        }

        private int _project = 0;
        public int project
        {
            get { return data._project; }
            set { data._project = value; }
        }

        private int _purchase_orders_items_overdue = 0;
        public int purchase_orders_items_overdue
        {
            get { return data._purchase_orders_items_overdue; }
            set { data._purchase_orders_items_overdue = value; }
        }

        private int _calendar_events = 0;
        public int calendar_events
        {
            get { return data._calendar_events; }
            set { data._calendar_events = value; }
        }

        private int _todo_list = 0;
        public int todo_list
        {
            get { return data._todo_list; }
            set { data._todo_list = value; }
        }

        private int _notifications = 0;
        public int notifications
        {
            get { return data._notifications; }
            set { data._notifications = value; }
        }

        private int _add_quote = 0;
        public int add_quote
        {
            get { return data._add_quote; }
            set { data._add_quote = value; }
        }


    }

    //Enums go here
    public enum Frequency
    {
        [Description("Daily")]
        Daily,
        [Description("Weekly")]
        Weekly,
        [Description("Monthly")]
        Monthly,
    }


}