using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Customer_group
{
    public class ERPCustomer_group : ERPNextObjectBase
    {
        public ERPCustomer_group() : this(new ERPObject(DocType.Customer_group)) { }
        public ERPCustomer_group(ERPObject obj) : base(obj) { }

        public static ERPCustomer_group Create(string customergroupname)

        {
            ERPCustomer_group obj = new ERPCustomer_group();
            obj.customer_group_name = customergroupname;
            return obj;
        }

        public string customer_group_name
        {
            get { return data.customer_group_name; }
            set
            {
                data.customer_group_name = value;
                data.name = value;
            }

        }

        public string parent_customer_group
        {
            get { return data.parent_customer_group; }
            set { data.parent_customer_group = value; }
        }

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
        }

        public string default_price_list
        {
            get { return data.default_price_list; }
            set { data.default_price_list = value; }
        }

        public string payment_terms
        {
            get { return data.payment_terms; }
            set { data.payment_terms = value; }
        }

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public string credit_limits
        {
            get { return data.credit_limits; }
            set { data.credit_limits = value; }
        }


    }

    //Enums go here

}