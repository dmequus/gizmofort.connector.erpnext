using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Exchange_rate_revaluation
{
    public class ERPExchange_rate_revaluation : ERPNextObjectBase
    {
        public ERPExchange_rate_revaluation() : this(new ERPObject(DocType.Exchange_rate_revaluation)) { }
        public ERPExchange_rate_revaluation(ERPObject obj) : base(obj) { }

        public static ERPExchange_rate_revaluation Create(string postingdate, string company, string accounts, double totalgainloss, string amendedfrom)

        {
            ERPExchange_rate_revaluation obj = new ERPExchange_rate_revaluation();
            obj.posting_date = postingdate;
            obj.company = company;
            obj.accounts = accounts;
            obj.total_gain_loss = totalgainloss;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set
            {
                data.posting_date = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public double total_gain_loss
        {
            get { return data.total_gain_loss; }
            set { data.total_gain_loss = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}