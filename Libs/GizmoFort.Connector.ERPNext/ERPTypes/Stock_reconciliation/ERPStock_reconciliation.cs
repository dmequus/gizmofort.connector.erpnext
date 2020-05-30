using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_reconciliation
{
    public class ERPStock_reconciliation : ERPNextObjectBase
    {
        public ERPStock_reconciliation() : this(new ERPObject(DocType.Stock_reconciliation)) { }
        public ERPStock_reconciliation(ERPObject obj) : base(obj) { }

        public static ERPStock_reconciliation Create(string namingseries, string company, Purpose purpose, string postingdate, string postingtime, string items)

        {
            ERPStock_reconciliation obj = new ERPStock_reconciliation();
            obj.naming_series = namingseries;
            obj.company = company;
            obj.purpose = purpose;
            obj.posting_date = postingdate;
            obj.posting_time = postingtime;
            obj.items = items;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public Purpose purpose
        {
            get { return parseEnum<Purpose>(data.purpose); }
            set { data.purpose = value.ToString(); }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string posting_time
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        private int _seta_posting_time = 0;
        public int seta_posting_time
        {
            get { return data._seta_posting_time; }
            set { data._seta_posting_time = value; }
        }

        public string expense_account
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string reconciliation_json
        {
            get { return data.reconciliation_json; }
            set { data.reconciliation_json = value; }
        }

        private double _difference_amount = 0.0;
        public double difference_amount
        {
            get { return data._difference_amount; }
            set { data._difference_amount = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Purpose
    {
        [Description("Opening Stock")]
        OpeningStock,
        [Description("Stock Reconciliation")]
        StockReconciliation,
    }


}