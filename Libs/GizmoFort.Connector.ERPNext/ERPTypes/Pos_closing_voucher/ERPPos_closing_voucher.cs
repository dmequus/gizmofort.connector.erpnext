using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher
{
    public class ERPPos_closing_voucher : ERPNextObjectBase
    {
        public ERPPos_closing_voucher() : this(new ERPObject(DocType.Pos_closing_voucher)) { }
        public ERPPos_closing_voucher(ERPObject obj) : base(obj) { }

        public static ERPPos_closing_voucher Create(string periodstartdate, string periodenddate, string postingdate, string company, string posprofile, string user, double expenseamount, string custodyamount, double totalamount, double difference, string paymentreconciliationdetails, string paymentreconciliation, double grandtotal, double nettotal, double totalquantity, string taxes, string salesinvoicessummary, string amendedfrom)

        {
            ERPPos_closing_voucher obj = new ERPPos_closing_voucher();
            obj.period_start_date = periodstartdate;
            obj.period_end_date = periodenddate;
            obj.posting_date = postingdate;
            obj.company = company;
            obj.pos_profile = posprofile;
            obj.user = user;
            obj.expense_amount = expenseamount;
            obj.custody_amount = custodyamount;
            obj.total_amount = totalamount;
            obj.difference = difference;
            obj.payment_reconciliation_details = paymentreconciliationdetails;
            obj.payment_reconciliation = paymentreconciliation;
            obj.grand_total = grandtotal;
            obj.net_total = nettotal;
            obj.total_quantity = totalquantity;
            obj.taxes = taxes;
            obj.sales_invoices_summary = salesinvoicessummary;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string period_start_date
        {
            get { return data.period_start_date; }
            set
            {
                data.period_start_date = value;
                data.name = value;
            }

        }

        public string period_end_date
        {
            get { return data.period_end_date; }
            set { data.period_end_date = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string pos_profile
        {
            get { return data.pos_profile; }
            set { data.pos_profile = value; }
        }

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }

        public double expense_amount
        {
            get { return data.expense_amount; }
            set { data.expense_amount = value; }
        }

        public string custody_amount
        {
            get { return data.custody_amount; }
            set { data.custody_amount = value; }
        }

        public double total_amount
        {
            get { return data.total_amount; }
            set { data.total_amount = value; }
        }

        public double difference
        {
            get { return data.difference; }
            set { data.difference = value; }
        }

        public string payment_reconciliation_details
        {
            get { return data.payment_reconciliation_details; }
            set { data.payment_reconciliation_details = value; }
        }

        public string payment_reconciliation
        {
            get { return data.payment_reconciliation; }
            set { data.payment_reconciliation = value; }
        }

        public double grand_total
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
        }

        public double net_total
        {
            get { return data.net_total; }
            set { data.net_total = value; }
        }

        public double total_quantity
        {
            get { return data.total_quantity; }
            set { data.total_quantity = value; }
        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }

        public string sales_invoices_summary
        {
            get { return data.sales_invoices_summary; }
            set { data.sales_invoices_summary = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}