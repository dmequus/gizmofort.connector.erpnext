using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Currency_exchange
{
    public class ERPCurrency_exchange : ERPNextObjectBase
    {
        public ERPCurrency_exchange() : this(new ERPObject(DocType.Currency_exchange)) { }
        public ERPCurrency_exchange(ERPObject obj) : base(obj) { }

        public static ERPCurrency_exchange Create(string date, string fromcurrency, string tocurrency, double exchangerate, long forbuying, long forselling)

        {
            ERPCurrency_exchange obj = new ERPCurrency_exchange();
            obj.date = date;
            obj.from_currency = fromcurrency;
            obj.to_currency = tocurrency;
            obj.exchange_rate = exchangerate;
            obj.for_buying = forbuying;
            obj.for_selling = forselling;
            return obj;
        }

        public string date
        {
            get { return data.date; }
            set
            {
                data.date = value;
                data.name = value;
            }

        }

        public string from_currency
        {
            get { return data.from_currency; }
            set { data.from_currency = value; }
        }

        public string to_currency
        {
            get { return data.to_currency; }
            set { data.to_currency = value; }
        }

        public double exchange_rate
        {
            get { return data.exchange_rate; }
            set { data.exchange_rate = value; }
        }

        public long for_buying
        {
            get { return data.for_buying; }
            set { data.for_buying = value; }
        }

        public long for_selling
        {
            get { return data.for_selling; }
            set { data.for_selling = value; }
        }


    }

    //Enums go here

}