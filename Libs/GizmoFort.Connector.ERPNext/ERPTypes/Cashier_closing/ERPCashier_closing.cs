using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cashier_closing
{
    public class ERPCashier_closing : ERPNextObjectBase
    {
        public ERPCashier_closing() : this(new ERPObject(DocType.Cashier_closing)) { }
        public ERPCashier_closing(ERPObject obj) : base(obj) { }

        public static ERPCashier_closing Create(string namingseries, string user, string date, string fromtime, string time, double expense, double custody, double returns, double outstandingamount, string payments, double netamount, string amendedfrom)

        {
            ERPCashier_closing obj = new ERPCashier_closing();
            obj.naming_series = namingseries;
            obj.user = user;
            obj.date = date;
            obj.from_time = fromtime;
            obj.time = time;
            obj.expense = expense;
            obj.custody = custody;
            obj.returns = returns;
            obj.outstanding_amount = outstandingamount;
            obj.payments = payments;
            obj.net_amount = netamount;
            obj.amended_from = amendedfrom;
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

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string from_time
        {
            get { return data.from_time; }
            set { data.from_time = value; }
        }

        public string time
        {
            get { return data.time; }
            set { data.time = value; }
        }

        public double expense
        {
            get { return data.expense; }
            set { data.expense = value; }
        }

        public double custody
        {
            get { return data.custody; }
            set { data.custody = value; }
        }

        public double returns
        {
            get { return data.returns; }
            set { data.returns = value; }
        }

        public double outstanding_amount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }

        public string payments
        {
            get { return data.payments; }
            set { data.payments = value; }
        }

        public double net_amount
        {
            get { return data.net_amount; }
            set { data.net_amount = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}