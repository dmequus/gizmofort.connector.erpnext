using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Exchange_rate_revaluation_account
{
    public class ERPExchange_rate_revaluation_account : ERPNextObjectBase
    {
        public ERPExchange_rate_revaluation_account() : this(new ERPObject(DocType.Exchange_rate_revaluation_account)) { }
        public ERPExchange_rate_revaluation_account(ERPObject obj) : base(obj) { }

        public static ERPExchange_rate_revaluation_account Create(string account, string partytype, string party, string accountcurrency, double balanceinaccountcurrency, double currentexchangerate, double balanceinbasecurrency, double newexchangerate, double newbalanceinbasecurrency, double gainloss)

        {
            ERPExchange_rate_revaluation_account obj = new ERPExchange_rate_revaluation_account();
            obj.account = account;
            obj.party_type = partytype;
            obj.party = party;
            obj.account_currency = accountcurrency;
            obj.balance_in_account_currency = balanceinaccountcurrency;
            obj.current_exchange_rate = currentexchangerate;
            obj.balance_in_base_currency = balanceinbasecurrency;
            obj.new_exchange_rate = newexchangerate;
            obj.new_balance_in_base_currency = newbalanceinbasecurrency;
            obj.gain_loss = gainloss;
            return obj;
        }

        public string account
        {
            get { return data.account; }
            set
            {
                data.account = value;
                data.name = value;
            }

        }

        public string party_type
        {
            get { return data.party_type; }
            set { data.party_type = value; }
        }

        public string party
        {
            get { return data.party; }
            set { data.party = value; }
        }

        public string account_currency
        {
            get { return data.account_currency; }
            set { data.account_currency = value; }
        }

        private double _balance_in_account_currency = 0.0;
        public double balance_in_account_currency
        {
            get { return data._balance_in_account_currency; }
            set { data._balance_in_account_currency = value; }
        }

        private double _current_exchange_rate = 0.0;
        public double current_exchange_rate
        {
            get { return data._current_exchange_rate; }
            set { data._current_exchange_rate = value; }
        }

        private double _balance_in_base_currency = 0.0;
        public double balance_in_base_currency
        {
            get { return data._balance_in_base_currency; }
            set { data._balance_in_base_currency = value; }
        }

        private double _new_exchange_rate = 0.0;
        public double new_exchange_rate
        {
            get { return data._new_exchange_rate; }
            set { data._new_exchange_rate = value; }
        }

        private double _new_balance_in_base_currency = 0.0;
        public double new_balance_in_base_currency
        {
            get { return data._new_balance_in_base_currency; }
            set { data._new_balance_in_base_currency = value; }
        }

        private double _gain_loss = 0.0;
        public double gain_loss
        {
            get { return data._gain_loss; }
            set { data._gain_loss = value; }
        }


    }

    //Enums go here

}