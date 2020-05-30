using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Email_digest
{
    public class ERPEmail_digest : ERPNextObjectBase
    {
        public ERPEmail_digest() : this(new ERPObject(DocType.Email_digest)) { }
        public ERPEmail_digest(ERPObject obj) : base(obj) { }

        public static ERPEmail_digest Create(long enabled, string company, Frequency frequency, string nextsend, string recipientlist, long income, long expensesbooked, long incomeyeartodate, long expenseyeartodate, long bankbalance, long creditbalance, long invoicedamount, long payables, long salesorderstobill, long purchaseorderstobill, long salesorder, long purchaseorder, long salesorderstodeliver, long purchaseorderstoreceive, long salesinvoice, long purchaseinvoice, long newquotations, long pendingquotations, long issue, long project, long purchaseordersitemsoverdue, long calendarevents, long todolist, long notifications, long addquote)

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

        public long enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
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

        public long income
        {
            get { return data.income; }
            set { data.income = value; }
        }

        public long expenses_booked
        {
            get { return data.expenses_booked; }
            set { data.expenses_booked = value; }
        }

        public long income_year_to_date
        {
            get { return data.income_year_to_date; }
            set { data.income_year_to_date = value; }
        }

        public long expense_year_to_date
        {
            get { return data.expense_year_to_date; }
            set { data.expense_year_to_date = value; }
        }

        public long bank_balance
        {
            get { return data.bank_balance; }
            set { data.bank_balance = value; }
        }

        public long credit_balance
        {
            get { return data.credit_balance; }
            set { data.credit_balance = value; }
        }

        public long invoiced_amount
        {
            get { return data.invoiced_amount; }
            set { data.invoiced_amount = value; }
        }

        public long payables
        {
            get { return data.payables; }
            set { data.payables = value; }
        }

        public long sales_orders_to_bill
        {
            get { return data.sales_orders_to_bill; }
            set { data.sales_orders_to_bill = value; }
        }

        public long purchase_orders_to_bill
        {
            get { return data.purchase_orders_to_bill; }
            set { data.purchase_orders_to_bill = value; }
        }

        public long sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        public long purchase_order
        {
            get { return data.purchase_order; }
            set { data.purchase_order = value; }
        }

        public long sales_orders_to_deliver
        {
            get { return data.sales_orders_to_deliver; }
            set { data.sales_orders_to_deliver = value; }
        }

        public long purchase_orders_to_receive
        {
            get { return data.purchase_orders_to_receive; }
            set { data.purchase_orders_to_receive = value; }
        }

        public long sales_invoice
        {
            get { return data.sales_invoice; }
            set { data.sales_invoice = value; }
        }

        public long purchase_invoice
        {
            get { return data.purchase_invoice; }
            set { data.purchase_invoice = value; }
        }

        public long new_quotations
        {
            get { return data.new_quotations; }
            set { data.new_quotations = value; }
        }

        public long pending_quotations
        {
            get { return data.pending_quotations; }
            set { data.pending_quotations = value; }
        }

        public long issue
        {
            get { return data.issue; }
            set { data.issue = value; }
        }

        public long project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public long purchase_orders_items_overdue
        {
            get { return data.purchase_orders_items_overdue; }
            set { data.purchase_orders_items_overdue = value; }
        }

        public long calendar_events
        {
            get { return data.calendar_events; }
            set { data.calendar_events = value; }
        }

        public long todo_list
        {
            get { return data.todo_list; }
            set { data.todo_list = value; }
        }

        public long notifications
        {
            get { return data.notifications; }
            set { data.notifications = value; }
        }

        public long add_quote
        {
            get { return data.add_quote; }
            set { data.add_quote = value; }
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